using BusinessObject;
using Service.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface IPressService
    {
        Task<IEnumerable<Press>?> GetAll();
        Task<IEnumerable<Press>> GetAllWithInclude(string include);
        Task<IEnumerable<Press>> GetAllWith2Include(string include1, string include2);
        Task<Press?> GetById(int id);
        Task<Press?> Create(PressRequest request);
        Task<Press?> Update(int id, PressRequest request);
        Task<Press?> DeleteById(int id);
    }
}
