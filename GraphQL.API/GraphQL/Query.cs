using GraphQL.API.Models;
using GraphQL.API.Services;

namespace GraphQL.API.GraphQL
{
    public class Query
    {
        private SBookService _sBookService = new SBookService();
        private BooksService _bookService;

        public Query(BooksService bookService)
        {
            _bookService = bookService;
        }

        // static service
        public SBook GetSBook(int id) => _sBookService.GetSBook(id);
        public List<SBook> GetSBooks() => _sBookService.GetSBooks();

        // mongodb service
        public async Task<Book?> GetBook(string id) => await _bookService.GetAsync(id);
        public async Task<List<Book>> GetBooks(int page = 0, int size = 10, string search = "") => await _bookService.GetAsync(page,size, search);
    }
}