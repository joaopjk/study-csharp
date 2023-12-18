using Api.Domain.Dtos.Cep;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Services.Cep;
using Api.Domain.Repositories;
using AutoMapper;
using System;
using System.Threading.Tasks;

namespace Api.Service.Services
{
    public class CepService : ICepService
    {
        private readonly ICepRepository _repository;
        private readonly IMapper _mapper;

        public CepService(ICepRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<CepDto> Get(Guid id)
        {
            return _mapper.Map<CepDto>(
                await _repository.SelectAsync(id));
        }

        public async Task<CepDto> Get(string cep)
        {
            return _mapper.Map<CepDto>(
                await _repository.SelectAsync(cep));
        }

        public async Task<CepDtoCreateResult> Post(CepDtoCreate cep)
        {
            return _mapper.Map<CepDtoCreateResult>(
                await _repository.InsertAsync(_mapper.Map<CepEntity>(cep)));
        }

        public async Task<CepDtoUpdateResult> Put(CepDtoUpdate cep)
        {
            return _mapper.Map<CepDtoUpdateResult>(
                await _repository.UpdateAsync(_mapper.Map<CepEntity>(cep)));
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }
    }
}
