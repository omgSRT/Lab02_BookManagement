using BusinessObject;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
    public class BookService : IBookService
    {
        public Task<Book> Create(Book book)
        {
            throw new NotImplementedException();
        }

        public Task<Book> DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Book>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Book> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Book> Update(int id, Book book)
        {
            throw new NotImplementedException();
        }
    }
}
