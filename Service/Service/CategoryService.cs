using BusinessObject;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
    public class CategoryService : ICategoryService
    {
        public Task<Category> Create(Category category)
        {
            throw new NotImplementedException();
        }

        public Task<Category> DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Category>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Category> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Category> Update(int id, Category category)
        {
            throw new NotImplementedException();
        }
    }
}
