using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.API.Models;
using GraphQL.API.Services;

namespace GraphQL.API.GraphQL
{
    public class Mutation
    {
        private BookService _bookService = new BookService();
        public List<Book> AddBook(Book book)
        {
            _bookService.AddBook(book);
            return _bookService.GetBooks();
        }
        public List<Book> DeleteBook(int id)
        {
            _bookService.DeleteBook(id);
            return _bookService.GetBooks();
        }

        public Book UpdateBook(int id, Book book)
        {
            _bookService.UpdateBook(id, book);
            return book;
        }
    }
}