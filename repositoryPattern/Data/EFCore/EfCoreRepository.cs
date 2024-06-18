using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace repositoryPattern.Data.EFCore
{
        public abstract class EfCoreRepository<TEntity, TContext> : IRepository<TEntity>
            where TEntity : class, IEntity
            where TContext : DbContext
        {
            private readonly TContext context;
            public EfCoreRepository (TContext context){
                this.context = context;
            }
            public async Task<TEntity> AddNewData(TEntity entity)
            {
                context.Set<TEntity>().Add(entity);
                await context.SaveChangesAsync();
                return entity;
            }

            public async Task<TEntity> DeleteData(int id)
            {
                var entity = await context.Set<TEntity>().FindAsync(id);
                if (entity == null)
                {
                    return entity;
                }

                context.Set<TEntity>().Remove(entity);
                await context.SaveChangesAsync();

                return entity;
            }

            public async Task<TEntity> GetDataById(int id)
            {
                return await context.Set<TEntity>().FindAsync(id);
            }

            public async Task<List<TEntity>> GetAllData()
            {
                return await context.Set<TEntity>().ToListAsync();
            }

            public async Task<TEntity> UpdateDataById(TEntity entity)
            {
                context.Entry(entity).State = EntityState.Modified;
                await context.SaveChangesAsync();
                return entity;
            }

        }
}
