using BabySitter.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BabySitter.Repositories
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        public abstract Task Create(T entity);

        public abstract Task Delete(T entity);

        public abstract IQueryable<T> FindAll();

        public abstract IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression);

        public abstract Task<T> FindById<TypeOfId>(TypeOfId id);

        public Task Update(T entity)
        {
            throw new NotImplementedException();
        }

        //  public abstract Task Update(T entity);
    }
}
