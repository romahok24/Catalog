using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProductCatalog.DTO.DTO;
using ProductCatalog.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using static ProductCatalog.Constants.Constants;

namespace ProductCatalog.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = Roles.Admin)]
    public class AdminController : ControllerBase
    {
        IAdminService _service;

        public AdminController(IAdminService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserDTO>>> Get()
        {
            var response = await _service.Read();

            if (!response.Succeeded)
            {
                return BadRequest(response.Message);
            }

            return Ok(response.Result);
        }

        [HttpGet(RoutingValues.Id)]
        public async Task<ActionResult<UserDTO>> Get(string id)
        {
            var response = await _service.Read(id);

            if (!response.Succeeded)
            {
                return NotFound(response.Message);
            }

            return Ok(response.Result);
        }

        [HttpPost]
        public async Task<ActionResult> Post(UserDTO dto)
        {
            var response = await _service.Create(dto);

            if (!response.Succeeded)
            {
                return BadRequest(response.Message);
            }

            return Ok();
        }

        [HttpPost]
        [Route(RoutingValues.Block)]
        public async Task<ActionResult> BlockUser(string id)
        {
            var response = await _service.BlockUser(id);

            if (!response.Succeeded)
            {
                return BadRequest(response.Message);
            }

            return Ok(response.Message);
        }

        [HttpPost(RoutingValues.UpdatePassword)]
        public async Task<ActionResult> UpdatePassword(ChangePasswordDTO model)
        {
            var response = await _service.UpdatePassword(model);

            if (!response.Succeeded)
            {
                return BadRequest(response.Message);
            }

            return Ok(response.Message);
        }

        [HttpDelete(RoutingValues.Id)]
        public async Task<ActionResult> Delete(string id)
        {
            var response = await _service.Delete(id);

            if (!response.Succeeded)
            {
                return BadRequest(response.Message);
            }

            return Ok();
        }

        [HttpGet]
        [Route(RoutingValues.Roles)]
        public async Task<ActionResult<IEnumerable<string>>> GetRoles()
        {
            var response = await _service.GetAllRoles();

            if (response.Succeeded)
            {
                return Ok(response.Result);
            }

            return BadRequest(response.Message);
        }
    }
}