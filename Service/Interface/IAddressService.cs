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
        Task<IEnumerable<Address>?> GetAll();
        Task<IEnumerable<Address>> GetAllWithInclude(string include);
        Task<IEnumerable<Address>> GetAllWith2Include(string include1, string include2);
        Task<Address?> GetById(int id);
        Task<Address?> Create(AddressRequest request);
        Task<Address?> Update(int id, AddressRequest request);
        Task<Address?> DeleteById(int id);
    }
}
