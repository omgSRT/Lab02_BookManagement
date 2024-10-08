﻿using BusinessObject;
using Repository.GenericRepository;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class BookRepository : GenericRepository<Book>, IBookRepository
    {
        public BookRepository() { }
        public BookRepository(ApplicationDbContext context) => _context = context;
    }
}
