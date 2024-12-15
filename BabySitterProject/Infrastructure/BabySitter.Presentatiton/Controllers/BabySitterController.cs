using BabySitter.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BabySitter.Presentatiton.Controllers
{
    public class BabySitterController: BaseController
    {
        public BabySitterController(IServiceManager serviceManager):base(serviceManager) { }

        public IActionResult Get()
        {
            var data=_serviceManager.BabySitterService.FindById<int>(4);
            return Ok(data);
        }
       

        

    }
}
