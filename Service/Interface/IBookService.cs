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
        Task<IEnumerable<Book>> GetAllWithInclude(string include);
        Task<IEnumerable<Book>> GetAllWith2Include(string include1, string include2);
        Task<Book?> GetById(int id);
        Task<Book?> Create(BookRequest request);
        Task<Book?> Update(int id, BookRequest request);
        Task<Book?> DeleteById(int id);
    }
}
