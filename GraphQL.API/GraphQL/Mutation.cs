using GraphQL.API.Models;
using GraphQL.API.Services;

namespace GraphQL.API.GraphQL
{
    public class Mutation
    {
        private SBookService _bookService = new SBookService();
        public List<SBook> AddSBook(SBook book)
        {
            _bookService.AddSBook(book);
            return _bookService.GetSBooks();
        }
        public List<SBook> DeleteSBook(int id)
        {
            _bookService.DeleteSBook(id);
            return _bookService.GetSBooks();
        }

        public SBook UpdateSBook(int id, SBook book)
        {
            _bookService.UpdateSBook(id, book);
            return book;
        }
    }
}