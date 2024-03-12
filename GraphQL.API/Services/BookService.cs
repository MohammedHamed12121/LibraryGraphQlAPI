using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.API.Models;

namespace GraphQL.API.Services
{
    public class BookService
    {
        private static List<Book> _books; 
        public BookService()
        {
            _books = new List<Book>
            {
                new Book { Id = 1, Title = "Book 1", Author = new Author { Id = 1, Name = "Author 1" } },
                new Book { Id = 2, Title = "Book 2", Author = new Author { Id = 2, Name = "Author 2" } },
                new Book { Id = 3, Title = "Book 3", Author = new Author { Id = 3, Name = "Author 3" } }
            };
        }

        public List<Book> GetBooks()
        {
            return _books;
        }

        public Book GetBook(int id)
        {
            return _books.Where(b => b.Id == id).FirstOrDefault();
        }
        public void AddBook(Book book)
        {
            _books.Add(book);
        }
        public void DeleteBook(int id)
        {
            var book  = GetBook(id);
            _books.Remove(book);
        }
        public void UpdateBook(int id,Book book)
        {
            if(_books.Where(f => f.Id == id).FirstOrDefault() is not null)
            {
                DeleteBook(id);
            }
            AddBook(book);
        }
    }
}