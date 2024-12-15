using BabySitter.Repositories.Contracts.MSSQLDB;

namespace BabySitter.Repositories.Contracts
{
    public interface IRepositoryManager
    {
        public IProductRepository ProductRepository { get; }
    }
}
