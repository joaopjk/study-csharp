using Api.Domain.Interfaces.Services.Cep;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using System.Net;
using Api.Domain.Dtos.Cep;

namespace Api.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CepsController : ControllerBase
    {
        private readonly ICepService _service;

        public CepsController(ICepService service)
        {
            _service = service;
        }

        [AllowAnonymous]
        [HttpGet("{id:guid}", Name = "GetCepWithId")]
        public async Task<ActionResult> Get(Guid id)
        {

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var result = await _service.Get(id);
                if (result == null)
                    return NotFound();
                return Ok(result);
            }
            catch (Exception e)
            {
                return HandleError(e);
            }
        }

        [AllowAnonymous]
        [HttpGet("byCep/{cep:alpha}")]
        public async Task<ActionResult> GetByCep(string cep)
        {

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var result = await _service.Get(cep);
                if (result == null)
                    return NotFound();
                return Ok(result);
            }
            catch (Exception e)
            {
                return HandleError(e);
            }
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CepDtoCreate cep)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var result = await _service.Post(cep);
                if (result != null)
                    return Created(new Uri(Url.Link("GetCepWithId", new { id = result.Id })), result);
                return BadRequest();
            }
            catch (Exception e)
            {
                return HandleError(e);
            }
        }

        [AllowAnonymous]
        [HttpPut]
        public async Task<ActionResult> Put([FromBody] CepDtoUpdate cep)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var result = await _service.Put(cep);
                if (result != null)
                    return Created(new Uri(Url.Link("GetCepWithId", new { id = result.Id })), result);
                return BadRequest();
            }
            catch (Exception e)
            {
                return HandleError(e);
            }
        }

        [AllowAnonymous]
        [HttpDelete("{id:guid}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                return Ok(await _service.Delete(id));
            }
            catch (Exception e)
            {
                return HandleError(e);
            }
        }

        private ObjectResult HandleError(Exception ex)
        {
            return StatusCode((int)HttpStatusCode.InternalServerError, ex.InnerException?.Message ?? ex.Message);
        }
    }
}
