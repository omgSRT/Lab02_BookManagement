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
    public class AddressRepository : GenericRepository<Address>, IAddressRepository
    {
        public AddressRepository() { }
        public AddressRepository(ApplicationDbContext context) => _context = context;
    }
}
