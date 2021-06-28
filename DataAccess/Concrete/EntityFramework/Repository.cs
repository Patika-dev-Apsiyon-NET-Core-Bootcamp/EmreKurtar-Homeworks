using DataAccess.Abstract;
using Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class Repository<TEntity>  : IRepositoryBase<TEntity> where TEntity : Entity
    {
        protected readonly MyDBContext _context = null;
        private DbSet<TEntity> _entities = null;

        public Repository(MyDBContext context)
        {
            _context = context;
            _entities = _context.Set<TEntity>();
        }

        public async Task<int> Add(TEntity item)
        {
            _entities.Add(item);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Delete(TEntity item)
        {
             _entities.Remove(item);
            return await _context.SaveChangesAsync();
        }

        public async Task<TEntity> Get(int id)
        {
            return await _entities.FirstOrDefaultAsync(item => item.ID == id);
             
        }

        public async Task<List<TEntity>> GetAll()
        {
            return await _entities.ToListAsync();
        }

        public async Task<int> Update(TEntity item)
        {
            return await _context.SaveChangesAsync();
        }
    }
}

