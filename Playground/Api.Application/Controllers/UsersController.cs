using Api.Domain.Entities;
using Api.Domain.Interfaces.Services.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using System.Threading.Tasks;

namespace Api.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [Authorize("Bearer")]
        [HttpGet]
        public async Task<ActionResult> GetAll([FromServices] IUserService service)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                return Ok(await service.GetAll());
            }
            catch (Exception ex)
            {
                return HandleError(ex);
            }
        }

        [Authorize("Bearer")]
        [HttpGet]
        [Route("{id:guid}", Name = "GetWithId")]
        public async Task<ActionResult> Get([FromServices] IUserService service, Guid id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                return Ok(await service.Get(id));
            }
            catch (Exception ex)
            {
                return HandleError(ex);
            }
        }

        [Authorize("Bearer")]
        [HttpPost]
        public async Task<ActionResult> Post([FromServices] IUserService service, [FromBody] UserEntity entity)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var result = await service.Post(entity);
                if (result != null)
                    return Created(new Uri(Url.Link("GetWithId", new { id = result.Id })), result);
                return BadRequest();

            }
            catch (Exception ex)
            {
                return HandleError(ex);
            }
        }

        [Authorize("Bearer")]
        [HttpPut]
        public async Task<ActionResult> Put([FromServices] IUserService service, [FromBody] UserEntity entity)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var result = await service.Put(entity);
                if (result != null)
                    return Ok(result);
                return BadRequest();
            }
            catch (Exception ex)
            {
                return HandleError(ex);
            }
        }

        [Authorize("Bearer")]
        [HttpDelete("{id:guid}")]
        public async Task<ActionResult> Delete([FromServices] IUserService service, Guid id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                return Ok(await service.Delete(id));
            }
            catch (Exception ex)
            {
                return HandleError(ex);
            }
        }

        private ObjectResult HandleError(Exception ex)
        {
            return StatusCode((int)HttpStatusCode.InternalServerError, ex.InnerException.Message ?? ex.Message);
        }
    }
}
