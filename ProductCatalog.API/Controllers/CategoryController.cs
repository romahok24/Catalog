using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProductCatalog.DTO;
using ProductCatalog.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using static ProductCatalog.Constants.Constants;

namespace ProductCatalog.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "User, SuperUser")]
    public class CategoryController : ControllerBase
    {
        ICategoryService _service;

        public CategoryController(ICategoryService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<CategoryDTO>> Get()
        {
            var response = _service.Read();

            if (!response.Succeeded)
            {
                return BadRequest(response.Message);
            }

            return Ok(response.Result);
        }

        [HttpGet(RoutingValues.Id)]
        public ActionResult<CategoryDTO> Get(int id)
        {
            var response = _service.Read(id);

            if (!response.Succeeded)
            {
                return NotFound(response.Message);
            }

            return Ok(response.Result);
        }

        [HttpPost]
        [Authorize(Roles = Roles.SuperUser)]
        public async Task<ActionResult> Post(CategoryDTO dto)
        {
            var response = await _service.Create(dto);

            if (!response.Succeeded)
            {
                return BadRequest(response.Message);
            }

            return Ok();
        }

        [HttpPut]
        [Authorize(Roles = Roles.SuperUser)]
        public async Task<ActionResult> Put(CategoryDTO dto)
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