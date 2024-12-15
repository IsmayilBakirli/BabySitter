using BabySitter.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabySitter.Services.Contracts.Business
{
    public interface IProductService
    {
        Task<List<Product>> GetAll();
        Task Create(Product product);
    }
}
