using Api.Domain.Dtos.UF;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Domain.Interfaces.Services.Uf
{
    public interface IUfService
    {
        Task<UfDto> Get(Guid id);
        Task<IEnumerable<UfDto>> GetAll();
    }
}
