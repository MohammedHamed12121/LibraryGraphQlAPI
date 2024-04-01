using GraphQL.API.Models;
using GraphQL.API.Services;

namespace GraphQL.API.GraphQL
{
    public class Mutation
    {
        private SBookService _sBookService = new SBookService();
        private BooksService _booksService;

        public Mutation(BooksService booksService)
        {
            _booksService = booksService;
        }

        // Static service 
        public List<SBook> AddSBook(SBook book)
        {
            _sBookService.AddSBook(book);
            return _sBookService.GetSBooks();
        }
        public List<SBook> DeleteSBook(int id)
        {
            _sBookService.DeleteSBook(id);
            return _sBookService.GetSBooks();
        }

        public SBook UpdateSBook(int id, SBook book)
        {
            _sBookService.UpdateSBook(id, book);
            return book;
        }

        // MongoDB service 
        public async Task<Book> AddBook(Book newBook)
        {
            await _booksService.CreateAsync(newBook);

            return await _booksService.GetAsync(newBook.Id);
        }

        public async Task<Book> UpdateBook(string id, Book updatedBook)
        {
            var book = await _booksService.GetAsync(id);
            updatedBook.Id = book.Id;

            await _booksService.UpdateAsync(id, updatedBook);

            return updatedBook;
        }
        public async Task<Book> DeleteBook(string id)
        {
            var book = await _booksService.GetAsync(id);

            await _booksService.RemoveAsync(id);

            return book;
        }
    }
}