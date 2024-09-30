using AutoMapper;
using BusinessObject;
using Repository.UnitOfWork;
using Service.DTO;
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
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public BookService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Book?> Create(BookRequest request)
        {
            try
            {
                var address = await _unitOfWork.AddressRepository.GetByIdAsync(request.AddressId);
                var press = await _unitOfWork.PressRepository.GetByIdAsync(request.PressId);
                if (address != null && press != null)
                {
                    var newBook = _mapper.Map<Book>(request);
                    var result = await _unitOfWork.BookRepository.CreateAsync(newBook);
                    if (result > 0)
                    {
                        return newBook;
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public async Task<Book?> DeleteById(int id)
        {
            try
            {
                var book = await _unitOfWork.BookRepository.GetByIdAsync(id);
                if (book != null) {
                    var result = await _unitOfWork.BookRepository.RemoveAsync(book);
                    if (result)
                    {
                        return book;
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public async Task<IEnumerable<Book>?> GetAll()
        {
            try
            {
                var list = await _unitOfWork.BookRepository.GetAllAsync();
                if (list != null)
                {
                    return list;
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public async Task<Book?> GetById(int id)
        {
            try
            {
                var book = await _unitOfWork.BookRepository.GetByIdAsync(id);
                if (book != null)
                {
                    return book;
                }
                return null;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public Task<Book?> Update(int id, BookRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
