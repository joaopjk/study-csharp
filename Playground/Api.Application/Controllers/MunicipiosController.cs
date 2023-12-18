using Api.Domain.Interfaces.Services.Municipio;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System;
using Microsoft.AspNetCore.Authorization;
using System.Threading.Tasks;
using Api.Domain.Dtos.Municipio;

namespace Api.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MunicipiosController : ControllerBase
    {
        private readonly IMunicipioService _service;

        public MunicipiosController(IMunicipioService service)
        {
            _service = service;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            if (!ModelState.IsValid)
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
        [HttpGet("{id:guid}", Name = "GetMunicipioWithId")]
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

        [AllowAnonymous]
        [HttpGet("CompletedByIdMunicipio/{idMunicipio:guid}")]
        public async Task<ActionResult> GetCompleteByIdMunicipio(Guid idMunicipio)
        {

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                return Ok(await _service.GetCompleteById(idMunicipio));
            }
            catch (Exception e)
            {
                return HandleError(e);
            }
        }

        [AllowAnonymous]
        [HttpGet("CompletedByIdIbg/{idIbge:int}")]
        public async Task<ActionResult> GetCompleteByIdIbge(int idIbge)
        {

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                return Ok(await _service.GetCompleteByIbge(idIbge));
            }
            catch (Exception e)
            {
                return HandleError(e);
            }
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] MunicipioDtoCreate municipio)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var result = await _service.Post(municipio);
                if (result != null)
                    return Created(new Uri(Url.Link("GetMunicipioWithId", new { id = result.Id })), result);
                return BadRequest();
            }
            catch (Exception e)
            {
                return HandleError(e);
            }
        }

        [AllowAnonymous]
        [HttpPut]
        public async Task<ActionResult> Put([FromBody] MunicipioDtoUpdate municipio)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var result = await _service.Put(municipio);
                if (result != null)
                    return Created(new Uri(Url.Link("GetMunicipioWithId", new { id = result.Id })), result);
                return BadRequest();
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
