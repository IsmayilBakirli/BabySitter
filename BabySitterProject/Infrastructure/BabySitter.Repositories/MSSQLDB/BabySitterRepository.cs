using BabySitter.Repositories.Contracts.MSSQLDB;

namespace BabySitter.Repositories.MSSQLDB
{
    public class BabySitterRepository : MsSqlDbRepositoryBase<Entities.BabySitter>, IBabySitterRepository
    {
        private readonly AppDbContext appDbContext;
        public BabySitterRepository(AppDbContext context) : base(context)
        {

        }
    }
}