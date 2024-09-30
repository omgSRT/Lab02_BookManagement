using BusinessObject;
using Service.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>?> GetAll();
        Task<Category?> GetById(int id);
        Task<Category?> Create(CategoryRequest request);
        Task<Category?> Update(int id, CategoryRequest request);
        Task<Category?> DeleteById(int id);
    }
}
