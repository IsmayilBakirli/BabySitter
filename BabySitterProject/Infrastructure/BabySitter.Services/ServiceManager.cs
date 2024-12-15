using BabySitter.Services.Contracts;
using BabySitter.Services.Contracts.Business;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabySitter.Services
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<IBabySitterService> _babySitterService;
        private readonly Lazy<IProductService> _productService;
        public ServiceManager(IServiceProvider serviceProvider)
        {
            _babySitterService = new Lazy<IBabySitterService>(() => serviceProvider.GetRequiredService<IBabySitterService>());
            _productService = new Lazy<IProductService>(() => serviceProvider.GetRequiredService<IProductService>());
        }

        public IBabySitterService BabySitterService => _babySitterService.Value;

        public IProductService ProductService =>_productService.Value;
    }
}
