using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface IPressService
    {
        Task<IEnumerable<Press>> GetAll();
        Task<Press> GetById(long id);
        Task<Press> Create(Press press);
        Task<Press> Update(long id, Press press);
        Task<Press> DeleteById(long id);
        Task<Press> GetById(long? id);
    }
}
