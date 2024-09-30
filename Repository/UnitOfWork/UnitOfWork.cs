using BusinessObject;
using Repository.Interface;
using Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _context;

        private IAddressRepository _addressRepository;
        private IBookRepository _bookRepository;
        private ICategoryRepository _categoryRepository;
        private IPressRepository _pressRepository;

        public UnitOfWork()
        {
            _addressRepository = new AddressRepository();
            _bookRepository = new BookRepository();
            _categoryRepository = new CategoryRepository();
            _pressRepository = new PressRepository();
        }

        public IAddressRepository AddressRepository
        {
            get
            {
                return _addressRepository ??= new AddressRepository(_context);
            }
        }
        public IBookRepository BookRepository
        {
            get
            {
                return _bookRepository ??= new BookRepository(_context);
            }
        }
        public ICategoryRepository CategoryRepository
        {
            get
            {
                return _categoryRepository ??= new CategoryRepository(_context);
            }
        }
        public IPressRepository PressRepository
        {
            get
            {
                return _pressRepository ??= new PressRepository(_context);
            }
        }
    }
}
