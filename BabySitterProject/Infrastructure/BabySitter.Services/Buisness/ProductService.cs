using BabySitter.Entities;
using BabySitter.Repositories.Contracts;
using BabySitter.Services.Contracts.Business;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabySitter.Services.Buisness
{
    public class ProductService : IProductService
    {
        private readonly IRepositoryManager _repositoryManager;
        public ProductService(IRepositoryManager repositoryManager) => _repositoryManager = repositoryManager;

        public async Task Create(Product product)
        {
            //image yoxlamag
           await _repositoryManager.ProductRepository.Create(product);

        }

        public async  Task<List<Product>> GetAll()
        {
            var data = await _repositoryManager.ProductRepository.FindAll().Where(n=>!n.IsDeleted).AsNoTracking().ToListAsync();
            return data;
        }

    }
}
