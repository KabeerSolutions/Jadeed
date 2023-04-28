using Jadeed.Data.Contexts;
using Jadeed.Data.IRepositories;
using Jadeed.Domain.Commons;
using Microsoft.EntityFrameworkCore;
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

        public ValueTask<bool> DeleteAsync(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public ValueTask<int> DeleteManyAsync(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetAll(Expression<Func<T, bool>> expression, IEnumerable<string> includes = null)
        {
            throw new NotImplementedException();
        }

        public ValueTask<T> GetAsync(Expression<Func<T, bool>> expression, IEnumerable<string> includes = null)
        {
            throw new NotImplementedException();
        }

        public ValueTask<T> InsertAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public ValueTask SaveAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<T> UpdateAsync(Expression<Func<T, bool>> expression, T entity)
        {
            throw new NotImplementedException();
        }
    }
}
