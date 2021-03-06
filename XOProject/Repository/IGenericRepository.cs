using System;
using System.Linq;
using System.Threading.Tasks;

namespace XOProject
{
    public interface IGenericRepository<T>
    {
        Task<T> GetAsync(string id);

        IQueryable<T> Query();

        Task InsertAsync(T entity);

        Task UpdateAsync(T entity);
        IQueryable<T> QueryWithOptions(Func<T, bool> where);
    }
}