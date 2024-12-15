using BabySitter.Entities;
using BabySitter.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabySitter.Presentatiton.Controllers
{
    [Route("api/[controller]/[action]"),ApiController]
    public class ProductController : BaseController
    {
        public ProductController(IServiceManager serviceManager) : base(serviceManager)
        {
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var data=await _serviceManager.ProductService.GetAll();
            return Ok(data);
        }
        [HttpPost]
        public async Task<IActionResult> Create(Product product)
        {
            
            await _serviceManager.ProductService.Create(product);
            return Ok();
        }

    }
}
