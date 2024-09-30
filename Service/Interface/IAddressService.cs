using BusinessObject;
using BusinessObject.DTO;
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
        Task<Address> Create(AddressRequest request);
        Task<Address> Update(long id, AddressRequest request);
        Task<Address> DeleteById(long id);
        Task<Address> GetById(long? id);
    }
}
