using BabySitter.Repositories.Contracts;
using BabySitter.Repositories.Contracts.MSSQLDB;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabySitter.Repositories
{
    public class RepositoryManager : IRepositoryManager
    {

        private readonly Lazy<IProductRepository>? _productRepository;
        public RepositoryManager(IServiceProvider serviceProvider)
        {
            _productRepository = new Lazy<IProductRepository>(() => serviceProvider.GetRequiredService < IProductRepository >());
                
        }

        public IProductRepository ProductRepository => _productRepository!.Value;

    }
}
