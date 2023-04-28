using Jadeed.Data.Contexts;
using Jadeed.Data.IRepositories;
using Jadeed.Domain.Commons;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq.Expressions;

namespace Jadeed.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : Auditable
    {
        private readonly JadeedDbContext context;
        private readonly DbSet<T> dbSet;

        public Repository(JadeedDbContext context)
        {
            this.context = context;
            dbSet = context.Set<T>();
        }

        /// <summary>
        /// Inserts element to a table and keep track of it until change saved
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async ValueTask<T> InsertAsync(T entity)
        {
            EntityEntry<T> entry = await this.dbSet.AddAsync(entity);

            return entry.Entity;
        }
        public async ValueTask<bool> DeleteAsync(Expression<Func<T, bool>> expression)
        {
            var entity = await this.GetAsync(expression);
            if (entity is not null)
            {
                this.dbSet.Remove(entity);
                return true;
            }
            return false;
        }

        /// <summary>
        /// If expression matches method deletes all
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        public async ValueTask<int> DeleteManyAsync(Expression<Func<T, bool>> expression)
        {
            var entities = this.dbSet.Where(expression);
            int numberOfDeletion = entities.Count();
            if (entities.Any())
            {
                this.dbSet.RemoveRange(entities);
                return numberOfDeletion;
            }
            return numberOfDeletion;
        }

        /// <summary>
        /// Selects all elements from table that matches condition and include relations
        /// </summary>
        /// <param name="expression"></param>
        /// <param name="includes"></param>
        /// <returns></returns>
        public IQueryable<T> GetAll(Expression<Func<T, bool>> expression, IEnumerable<string> includes = null)
        {
            IQueryable<T> query = expression is null ? this.dbSet : this.dbSet.Where(expression);

            if (includes is not null)
            {
                foreach (var include in includes)
                    query = query.Include(include);
            }
            return query;
        }

        /// <summary>
        /// selects element from a table specified with expression and can includes relations
        /// </summary>
        /// <param name="expression"></param>
        /// <param name="includes"></param>
        /// <returns></returns>
        public async ValueTask<T> GetAsync(Expression<Func<T, bool>> expression, IEnumerable<string> includes = null) =>
            await this.GetAll(expression, includes).FirstOrDefaultAsync();
      
        /// <summary>
        /// Saves tracking changes and write changes to database
        /// </summary>
        /// <returns></returns>
        public async ValueTask SaveAsync()
        {
            await this.context.SaveChangesAsync();
        }

        /// <summary>
        /// Updates entity and keep track of it until change saved
        /// </summary>
        /// <param name="expression"></param>
        /// <param name="entity"></param>
        /// <returns></returns>
        public T Update(Expression<Func<T, bool>> expression, T entity)
        {
            EntityEntry<T> entry = this.context.Update(entity);

            return entry.Entity;
        }
    }
}
