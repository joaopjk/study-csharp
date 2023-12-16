using System;
using System.Net;
using System.Threading.Tasks;
using Api.Domain.Dtos;
using Api.Domain.Interfaces.Services.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginsController : ControllerBase
    {
        [AllowAnonymous]
        [HttpPost]
        public async Task<ActionResult> Login([FromServices] ILoginService service, [FromBody] LoginDto loginDto)
        {
            if(!ModelState.IsValid) 
                return BadRequest(ModelState);

            if(loginDto == null)
                return BadRequest();

            try
            {
                var result = await service.FindByLogin(loginDto);
                if (result == null)
                    return NotFound();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
