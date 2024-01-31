using System.Linq.Expressions;

namespace ProjectFinal.Domain.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        IList<T> GetAll();
        T GetById(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] includes);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);

        Task<IList<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task InsertAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
}
