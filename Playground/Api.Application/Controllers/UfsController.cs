using System;
using System.Net;
using System.Threading.Tasks;
using Api.Domain.Interfaces.Services.Uf;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UfsController : ControllerBase
    {
        private readonly IUfService _service;

        public UfsController(IUfService service)
        {
            _service = service;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                return Ok(await _service.GetAll());
            }
            catch (Exception e)
            {
                return HandleError(e);
            }
        }
        
        [AllowAnonymous]
        [HttpGet("{id:guid}")]
        public async Task<ActionResult> Get(Guid id)
        {

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                return Ok(await _service.Get(id));
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
