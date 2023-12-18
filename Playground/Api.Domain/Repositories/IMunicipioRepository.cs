using System;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Interfaces;

namespace Api.Domain.Repositories
{
    public interface IMunicipioRepository : IRepository<MunicipioEntity>
    {
        Task<MunicipioEntity> GetCompletedById(Guid id);
        Task<MunicipioEntity> GetCompleteByIbge(int codIbge);
    }
}
