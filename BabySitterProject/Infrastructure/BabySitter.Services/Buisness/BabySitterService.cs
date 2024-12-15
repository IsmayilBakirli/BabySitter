using BabySitter.Repositories.Contracts.MSSQLDB;
using BabySitter.Repositories.MSSQLDB;
using BabySitter.Services.Contracts.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BabySitter.Services.Buisness
{
    public class BabySitterService : IBabySitterService
    {
        private readonly IBabySitterRepository _babySitterRepository;
        public BabySitterService(IBabySitterRepository babySitterRepository)
        {
            _babySitterRepository = babySitterRepository;
        }

        public Task Create()
        {
            throw new NotImplementedException();
        }

        public Task Delete()
        {
            throw new NotImplementedException();
        }

        public IQueryable FindAll()
        {
            var data = _babySitterRepository.FindAll();
            return data;

        }

        public IQueryable FindByCondition(Expression<Func<Entities.BabySitter, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task FindById<TypeOfId>(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update()
        {
            throw new NotImplementedException();
        }

        List<Entities.BabySitter> IBabySitterService.FindAll()
        {
            throw new NotImplementedException();
        }
    }
}
