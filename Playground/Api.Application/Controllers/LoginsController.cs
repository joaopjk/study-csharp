using System;
using System.Net;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Services.User;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginsController : ControllerBase
    {
        [HttpPost]
        public async Task<ActionResult> Login([FromServices] ILoginService service, [FromBody] UserEntity user)
        {
            if(!ModelState.IsValid) 
                return BadRequest(ModelState);

            if(user == null)
                return BadRequest();

            try
            {
                var result = await service.FindByLogin(user);
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
