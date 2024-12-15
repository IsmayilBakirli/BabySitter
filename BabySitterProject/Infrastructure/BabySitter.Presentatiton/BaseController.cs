using BabySitter.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabySitter.Presentatiton
{
    public class BaseController:ControllerBase
    {
        private protected readonly IServiceManager _serviceManager;
        public BaseController(IServiceManager serviceManager) => _serviceManager = serviceManager;
    }
}
