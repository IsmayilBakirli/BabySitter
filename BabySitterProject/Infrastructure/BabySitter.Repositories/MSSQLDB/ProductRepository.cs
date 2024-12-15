using BabySitter.Entities;
using BabySitter.Repositories.Contracts.MSSQLDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabySitter.Repositories.MSSQLDB
{
    public class ProductRepository:MsSqlDbRepositoryBase<Product>,IProductRepository
    {
        private readonly AppDbContext _appDbContext;
        public ProductRepository(AppDbContext context):base(context)
        {
            
        }
    }
}
