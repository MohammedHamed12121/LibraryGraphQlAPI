using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.API.Models;
using GraphQL.API.Services;

namespace GraphQL.API.GraphQL
{
    public class Query
    {
        private BookService _bookService = new BookService();
        // List<Book> books = bookService.GetBooks();
        public Book GetBook(int id) => _bookService.GetBook(id);

        public List<Book> GetBooks() => _bookService.GetBooks();
    }
}