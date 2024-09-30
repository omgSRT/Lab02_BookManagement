using BusinessObject;
using Service.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface IBookService
    {
        Task<IEnumerable<Book>?> GetAll();
        Task<Book?> GetById(int id);
        Task<Book?> Create(BookRequest request);
        Task<Book?> Update(int id, BookRequest request);
        Task<Book?> DeleteById(int id);
    }
}
