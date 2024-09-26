using BusinessObject;
using Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.UnitOfWork
{
    public class UnitOfWork
    {
        private ApplicationDbContext _context;

        private AddressRepository _addressRepository;
        private BookRepository _bookRepository;
        private CategoryRepository _categoryRepository;
        private PressRepository _pressRepository;

        public UnitOfWork()
        {
            _addressRepository = new AddressRepository();
            _bookRepository = new BookRepository();
            _categoryRepository = new CategoryRepository();
            _pressRepository = new PressRepository();
        }

        public AddressRepository AddressRepository
        {
            get
            {
                return _addressRepository ??= new AddressRepository(_context);
            }
        }
        public BookRepository BookRepository
        {
            get
            {
                return _bookRepository ??= new BookRepository(_context);
            }
        }
        public CategoryRepository CategoryRepository
        {
            get
            {
                return _categoryRepository ??= new CategoryRepository(_context);
            }
        }
        public PressRepository PressRepository
        {
            get
            {
                return _pressRepository ??= new PressRepository(_context);
            }
        }
    }
}
