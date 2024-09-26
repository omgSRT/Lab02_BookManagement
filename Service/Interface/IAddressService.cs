using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface IAddressService
    {
        Task<IEnumerable<Address>> GetAll();
        Task<Address> GetById(long id);
        Task<Address> Create(Address address);
        Task<Address> Update(long id, Address address);
        Task<Address> DeleteById(long id);
        Task<Address> GetById(long? id);
    }
}
