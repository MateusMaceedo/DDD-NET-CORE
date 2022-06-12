using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoModeloDDD.Domain.Base;
using ProjetoModeloDDD.Domain.Interfaces;
using ProjetoModeloDDD.Infra.Data.Contexto;

namespace ProjetoModeloDDD.Infra.Data.Repositories
{
  public class RepositoryBase<T> : IAsyncRepository<T> where T:BaseEntity
    {
        private readonly ProjetoModeloContext _context;
        private readonly DbSet<T> _dbSet;
        public RepositoryBase(ProjetoModeloContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        public async Task<T> AddAsync(T entity)
        {
           if (entity == null) throw new Exception($"{typeof(T).Name} está nula ou não informada");
           await _dbSet.AddAsync(entity);
           return entity;
        }

        public Task DeleteAsync(T entity)
        {
            if (entity == null)
                throw new Exception($"{typeof(T).Name} está nula ou não informada");
            _dbSet.Remove(entity);
            return Task.FromResult(true);
        }

        public async Task<T> GetAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetByIdAsync(Expression<Func<T,bool>> expression)
        {
            return await _dbSet.Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<T>> ListAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public Task<T> UpdateAsync(T entity)
        {
            if (entity == null)
                throw new Exception($"{typeof(T).Name} está nula ou não informada");
            _dbSet.Update(entity);
            return Task.FromResult(entity);
        }
    }
}
