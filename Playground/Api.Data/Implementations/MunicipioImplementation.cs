using Api.Data.Context;
using Api.Data.Repositories;
using Api.Domain.Entities;
using Api.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace Api.Data.Implementations
{
    public class MunicipioImplementation : BaseRepository<MunicipioEntity>, IMunicipioRepository
    {
        private readonly DbSet<MunicipioEntity> _dbSet;
        public MunicipioImplementation(MyContext context) : base(context)
        {
            _dbSet = context.Set<MunicipioEntity>();
        }

        public async Task<MunicipioEntity> GetCompletedById(Guid id)
        {
            return await _dbSet.Include(m => m.Uf)
                .FirstOrDefaultAsync(m => m.Id.Equals(id));
        }

        public async Task<MunicipioEntity> GetCompleteByIbge(int codIbge)
        {
            return await _dbSet.Include(m => m.Uf)
                .FirstOrDefaultAsync(m => m.CodIbge.Equals(codIbge));
        }
    }
}
