using Api.Data.Context;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Data.Repositories
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly MyContext _context;
        private DbSet<T> _dbSet;
        public BaseRepository(MyContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public Task<bool> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<T> InsertAsync(T entity)
        {
            try
            {
                if (entity.Id == Guid.Empty)
                    entity.Id = Guid.NewGuid();

                entity.CreateAt = DateTime.UtcNow;

                _dbSet.Add(entity);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return entity;
        }

        public Task<T> SelectAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> SelectAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<T> UpdateAsync(T entity)
        {
            try
            {
                var result = await _dbSet.SingleOrDefaultAsync( _ => _.Id == entity.Id );
                if (result == null)
                    return null;

                entity.UpdateAt = DateTime.UtcNow;
                entity.CreateAt = result.CreateAt;

                _context.Entry(result).CurrentValues.SetValues(entity);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return entity;
        }
    }
}
