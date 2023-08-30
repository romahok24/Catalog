using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProductCatalog.DTO;
using ProductCatalog.DTO.DTO;
using ProductCatalog.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using static ProductCatalog.Constants.Constants;

namespace ProductCatalog.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "User, SuperUser")]
    public class ProductController : ControllerBase
    {
        IProductService _service;

        public ProductController(IProductService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ProductDTO>> Get()
        {
            var response = _service.Read();

            if (!response.Succeeded)
            {
                return BadRequest(response.Message);
            }

            return Ok(response.Result);
        }

        [HttpGet]
        [Route(RoutingValues.Filter)]
        public ActionResult<IEnumerable<ProductDTO>> Get(ProductFilterDTO filter)
        {
            var models = _service.Read(filter);

            return Ok(models);
        }

        [HttpGet(RoutingValues.Id)]
        public ActionResult<ProductDTO> Get(int id)
        {
            var response = _service.Read(id);

            if (!response.Succeeded)
            {
                return NotFound(response.Message);
            }

            return Ok(response.Result);
        }

        [HttpPost]
        public async Task<ActionResult> Post(ProductDTO dto)
        {
            var response = await _service.Create(dto);

            if (!response.Succeeded)
            {
                return BadRequest(response.Message);
            }

            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> Put(ProductDTO dto)
        {
            var response = await _service.Update(dto);

            if (!response.Succeeded)
            {
                return BadRequest(response.Message);
            }

            return Ok();
        }

        [HttpDelete(RoutingValues.Id)]
        [Authorize(Roles = Roles.SuperUser)]
        public async Task<ActionResult> Delete(int id)
        {
            var response = await _service.Delete(id);

            if (!response.Succeeded)
            {
                return BadRequest(response.Message);
            }

            return Ok();
        }
    }
}