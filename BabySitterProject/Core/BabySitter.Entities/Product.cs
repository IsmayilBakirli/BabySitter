using BabySitter.Entities.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabySitter.Entities
{
    public class Product : BaseEntity, IHasCreateDate, IHasUpdateDate
    {
        public DateTime CreateDate { get ; set; }
        public DateTime UpdateDate { get ; set; }
        public string? Name { get; set; }

        public double Price { get; set; }
    }
}
