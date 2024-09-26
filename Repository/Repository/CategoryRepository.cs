using BusinessObject;
using Repository.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class CategoryRepository : GenericRepository<Category>
    {
        public CategoryRepository() { }
        public CategoryRepository(ApplicationDbContext context) => _context = context;
    }
}
