using BusinessObject;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
    public class PressService : IPressService
    {
        public Task<Press> Create(Press press)
        {
            throw new NotImplementedException();
        }

        public Task<Press> DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Press>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Press> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Press> Update(int id, Press press)
        {
            throw new NotImplementedException();
        }
    }
}
