using LeaveManagement.Web.Contracts;
using LeaveManagement.Web.Data;
using LeaveManagement.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagement.Web.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationDbContext context;

        public GenericRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<T> AddAsync(T entity)
        {
            await context.AddAsync(entity);
            await context.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await context.Set<T>().FindAsync(id);
            if (entity != null)
            {
                context.Set<T>().Remove(entity);
            }

            await context.SaveChangesAsync();
        }

        public async Task<bool> Exists(int id)
        {
            var entity = await context.Set<T>().FindAsync(id);
            return entity != null;
        }

        public async Task<List<T>> GetAllAsync()
        {
            var entitiesList = await context.Set<T>().ToListAsync();
           
            if (entitiesList == null)
            {
                return null;
            }
            return entitiesList;
        }

        public async Task<T?> GetAsync(int? id)
        {
            if (id == null)
            {
                return null;
            }
            return await context.Set<T>().FindAsync(id);
        }

        public async Task<int> GetCountAsync()
        {
            var entitiesList = await context.Set<T>().ToListAsync();
            
            return entitiesList.Count();
        }

        public async Task UpdateAsync(T entity)
        {
            context.Update(entity);
            await context.SaveChangesAsync();
        }
    }
}
