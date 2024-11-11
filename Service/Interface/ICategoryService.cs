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
        Task<IEnumerable<Category>> GetAllWithInclude(string include);
        Task<IEnumerable<Category>> GetAllWith2Include(string include1, string include2);
        Task<Category?> GetById(int id);
        Task<Category?> Create(CategoryRequest request);
        Task<Category?> Update(int id, CategoryRequest request);
        Task<Category?> DeleteById(int id);
    }
}
