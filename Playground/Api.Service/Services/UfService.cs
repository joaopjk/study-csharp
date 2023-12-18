using Api.Domain.Dtos.UF;
using Api.Domain.Interfaces.Services.Uf;
using Api.Domain.Repositories;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Service.Services
{
    public class UfService : IUfService
    {
        private readonly IUfRepository _repository;
        private readonly IMapper _mapper;

        public UfService(IUfRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<UfDto> Get(Guid id)
        {
            return _mapper.Map<UfDto>(
                await _repository.SelectAsync(id));
        }

        public async Task<IEnumerable<UfDto>> GetAll()
        {
            return _mapper.Map<IEnumerable<UfDto>>(
                await _repository.SelectAsync());
        }
    }
}
