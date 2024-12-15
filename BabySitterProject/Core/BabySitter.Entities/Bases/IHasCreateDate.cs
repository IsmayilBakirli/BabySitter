using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabySitter.Entities.Bases
{
    public interface IHasCreateDate
    {
        DateTime CreateDate { get; set; }
    }
}
