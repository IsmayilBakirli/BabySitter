using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using BabySitter.Entities;

namespace BabySitter.Services.Contracts.Business
{
    public interface IBabySitterService
    {
        List<BabySitter.Entities.BabySitter> FindAll();
        IQueryable FindByCondition(Expression<Func<BabySitter.Entities.BabySitter,bool>> expression);
        Task FindById<TypeOfId>(int id);
        Task Create();
        Task Update();
        Task Delete(); 
    }
}
