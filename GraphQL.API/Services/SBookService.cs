using GraphQL.API.Models;

namespace GraphQL.API.Services
{
    public class SBookService
    {
        private static List<SBook> _SBooks; 
        public SBookService()
        {
            _SBooks = new List<SBook>
            {
                new SBook { Id = 1, Title = "SBook 1", Author = new Author { Id = 1, Name = "Author 1" } },
                new SBook { Id = 2, Title = "SBook 2", Author = new Author { Id = 2, Name = "Author 2" } },
                new SBook { Id = 3, Title = "SBook 3", Author = new Author { Id = 3, Name = "Author 3" } }
            };
        }

        public List<SBook> GetSBooks()
        {
            return _SBooks;
        }

        public SBook GetSBook(int id)
        {
            return _SBooks.Where(b => b.Id == id).FirstOrDefault();
        }
        public void AddSBook(SBook SBook)
        {
            _SBooks.Add(SBook);
        }
        public void DeleteSBook(int id)
        {
            var SBook  = GetSBook(id);
            _SBooks.Remove(SBook);
        }
        public void UpdateSBook(int id,SBook SBook)
        {
            if(_SBooks.Where(f => f.Id == id).FirstOrDefault() is not null)
            {
                DeleteSBook(id);
            }
            AddSBook(SBook);
        }
    }
}