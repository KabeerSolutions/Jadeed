using Jadeed.Domain.Commons;
using System.Linq.Expressions;

namespace Jadeed.Data.IRepositories
{
    public interface IRepository<T> where T : Auditable
    {
        ValueTask<T> InsertAsync(T entity);
        ValueTask<T> UpdateAsync(Expression<Func<T, bool>> expression, T entity);
        ValueTask<bool> DeleteAsync(Expression<Func<T, bool>> expression);
        ValueTask<int> DeleteManyAsync(Expression<Func<T, bool>> expression);
        IQueryable<T> GetAll(Expression<Func<T, bool>> expression, IEnumerable<string> includes = null);
        ValueTask<T> GetAsync(Expression<Func<T, bool>> expression, IEnumerable<string> includes = null);
        ValueTask SaveAsync();
    }
}
