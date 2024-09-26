using BusinessObject;
using Repository.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class AddressRepository : GenericRepository<Address>
    {
        public AddressRepository() { }
        public AddressRepository(ApplicationDbContext context) => _context = context;
    }
}
