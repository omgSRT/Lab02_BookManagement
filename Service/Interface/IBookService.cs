﻿using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface IBookService
    {
        Task<IEnumerable<Book>> GetAll();
        Task<Book> GetById(long id);
        Task<Book> Create(Book book);
        Task<Book> Update(long id, Book book);
        Task<Book> DeleteById(long id);
        Task<Book> GetById(long? id);
    }
}