using System.Threading.Tasks;
using Api.Domain.Interfaces;
using Api.Domain.Entities;

namespace Api.Domain.Repositories
{
    public interface ICepRepository : IRepository<CepEntity>
    {
        Task<CepEntity> SelectAsync(string cep);
    }
}
