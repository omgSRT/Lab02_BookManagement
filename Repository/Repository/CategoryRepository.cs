using BusinessObject;
using Repository.GenericRepository;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository() { }
        public CategoryRepository(ApplicationDbContext context) => _context = context;
    }
}
