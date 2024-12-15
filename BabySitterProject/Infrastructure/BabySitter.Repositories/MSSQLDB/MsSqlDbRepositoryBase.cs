using BabySitter.Repositories.Contracts.MSSQLDB;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BabySitter.Repositories.MSSQLDB
{
    public class MsSqlDbRepositoryBase<T> : RepositoryBase<T>, IMsSqlDbRepositoryBase<T> where T : class
    {
        protected readonly AppDbContext _dbContext;

        protected DbSet<T> _dbSet;

        public MsSqlDbRepositoryBase(AppDbContext context)
        {
            _dbSet = context.Set<T>();
            _dbContext = context;

        }
        public override async Task Create(T entity)
        {
            _dbContext.Set<T>().Add(entity);
            await _dbContext.SaveChangesAsync();
   
        }

        public override Task Delete(T entity)
        {
            throw new NotImplementedException();

        }

        public override IQueryable<T> FindAll()
        {
            return _dbContext.Set<T>();
        }

        public override IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public override Task<T> FindById<TypeOfId>(TypeOfId id)
        {
            throw new NotImplementedException();
        }

        public Task Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
