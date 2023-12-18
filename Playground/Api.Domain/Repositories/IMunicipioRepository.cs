using Api.Domain.Entities;
using Api.Domain.Interfaces;
using System;
using System.Threading.Tasks;

namespace Api.Domain.Repositories
{
    public interface IMunicipioRepository : IRepository<MunicipioEntity>
    {
        Task<MunicipioEntity> GetCompletedById(Guid id);
        Task<MunicipioEntity> GetCompleteByIbge(int codIbge);
    }
}
