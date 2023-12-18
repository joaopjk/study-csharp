using Api.Data.Context;
using Api.Data.Repositories;
using Api.Domain.Entities;
using Api.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Implementations
{
    public class UfImplementation : BaseRepository<UfEntity>, IUfRepository
    {
        private readonly DbSet<UfEntity> _dbSet;
        public UfImplementation(MyContext context) : base(context)
        {
            _dbSet = context.Set<UfEntity>();
        }
    }
}
