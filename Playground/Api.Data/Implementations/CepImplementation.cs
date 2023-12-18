using Api.Data.Context;
using Api.Data.Repositories;
using Api.Domain.Entities;
using Api.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Api.Data.Implementations
{
    public class CepImplementation : BaseRepository<CepEntity>, ICepRepository
    {
        private readonly DbSet<CepEntity> _dbSet;
        public CepImplementation(MyContext context) : base(context)
        {
            _dbSet = context.Set<CepEntity>();
        }

        public async Task<CepEntity> SelectAsync(string cep)
        {
            return await _dbSet.Include(c => c.Municipio)
                               .ThenInclude(m => m.Uf)
                               .FirstOrDefaultAsync(c => c.Cep.Equals(cep));
        }
    }
}
