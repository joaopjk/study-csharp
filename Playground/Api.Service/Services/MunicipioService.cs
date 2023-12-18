using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.Municipio;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Services.Municipio;
using Api.Domain.Repositories;
using AutoMapper;

namespace Api.Service.Services
{
    public class MunicipioService : IMunicipioService
    {
        private readonly IMunicipioRepository _repository;
        private readonly IMapper _mapper;

        public MunicipioService(IMunicipioRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<MunicipioDto> Get(Guid id)
        {
            return _mapper.Map<MunicipioDto>(
                await _repository.SelectAsync(id));
        }

        public async Task<MunicipioDtoCompleto> GetCompleteById(Guid id)
        {
            return _mapper.Map<MunicipioDtoCompleto>(
                await _repository.GetCompletedById(id));
        }

        public async Task<MunicipioDtoCompleto> GetCompleteByIbge(int codIbge)
        {
            return _mapper.Map<MunicipioDtoCompleto>(
                await _repository.GetCompleteByIbge(codIbge));
        }

        public async Task<IEnumerable<MunicipioDto>> GetAll()
        {
            return _mapper.Map<IEnumerable<MunicipioDto>>(
                await _repository.SelectAsync());
        }

        public async Task<MunicipioDtoCreateResult> Post(MunicipioDtoCreate municipio)
        {
            return _mapper.Map<MunicipioDtoCreateResult>(
                await _repository.InsertAsync(_mapper.Map<MunicipioEntity>(municipio)));
        }

        public async Task<MunicipioDtoUpdateResult> Put(MunicipioDtoUpdate municipio)
        {
            return _mapper.Map<MunicipioDtoUpdateResult>(
                await _repository.UpdateAsync(_mapper.Map<MunicipioEntity>(municipio)));
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }
    }
}
