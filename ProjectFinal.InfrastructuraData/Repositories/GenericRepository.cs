using Microsoft.EntityFrameworkCore;
using ProjectFinal.Domain.Repository;
using ProjectFinal.InfrastructuraData.Data;
using System.Linq.Expressions;

namespace ProjectFinal.InfrastructuraData.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public DataContext Context { get; set; }

        public GenericRepository(DataContext context)
        {
            Context = context;
        }

        public IList<T> GetAll()
        {
            IQueryable<T> query = Context.Set<T>();
            return query.ToList();
        }
         
        public T GetById(Expression<Func<T,bool>> where, params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> query = Context.Set<T>();
            foreach (var include in includes)
            {
                query = query.Include(include);
            }

            return query.FirstOrDefault(where);
        }

        public void Insert(T entity)
        {
            Context.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            Context.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            Context.Set<T>().Remove(entity);
        }

        public Task<IList<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task InsertAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
