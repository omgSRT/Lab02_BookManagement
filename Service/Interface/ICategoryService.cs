using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetAll();
        Task<Category> GetById(long id);
        Task<Category> Create(Category category);
        Task<Category> Update(long id, Category category);
        Task<Category> DeleteById(long id);
        Task<Category> GetById(long? id);
    }
}
