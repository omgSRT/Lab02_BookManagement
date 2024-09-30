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
    public class PressRepository : GenericRepository<Press>, IPressRepository
    {
        public PressRepository() { }
        public PressRepository(ApplicationDbContext context) => _context = context;
    }
}
