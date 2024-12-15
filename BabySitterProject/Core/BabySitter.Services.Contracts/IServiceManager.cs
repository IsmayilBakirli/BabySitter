using BabySitter.Services.Contracts.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabySitter.Services.Contracts
{
    public interface IServiceManager
    {
        public IBabySitterService BabySitterService { get; }
        public IProductService ProductService { get; }
    }
}