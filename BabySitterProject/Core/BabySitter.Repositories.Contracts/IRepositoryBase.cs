namespace BabySitter.Repositories.Contracts
{
    public interface IRepositoryBase<T>
    {
        IQueryable<T> FindAll();
        IQueryable<T> FindByCondition(Expression<Func<T,bool>> expression);
        Task<T> FindById<TypeOfId>(TypeOfId id);
        Task Create(T entity);
       Task Update(T entity);
        Task Delete(T entity); 
        
    }
}