using Microsoft.AspNetCore.Mvc;
using ProductCatalog.DTO;
using ProductCatalog.DTO.Infrastructure;
using ProductCatalog.Services.Interfaces;
using System.Threading.Tasks;
using static ProductCatalog.Constants.Constants;

namespace ProductCatalog.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        IAuthentificationService _service;

        public AuthController(IAuthentificationService service)
        {
            _service = service;
        }

        [HttpPost]
        [Route(RoutingValues.Login)]
        public async Task<ActionResult<AuthentificationDetails>> Authenticate([FromBody] AuthentificationModelDTO request)
        {
            var result = await _service.Authentificate(request);

            if (!result.Succeeded)
            {
                return BadRequest(result.Message);
            }

            return Ok(result.Result);
        }

        [HttpPost]
        [Route(RoutingValues.Register)]
        public async Task<IActionResult> Register(RegistrationModelDTO model)
        {
            var result = await _service.Register(model);

            if (!result.Succeeded)
            {
                return BadRequest(result.Message);
            }

            return Ok(result.Message);
        }
    }
}