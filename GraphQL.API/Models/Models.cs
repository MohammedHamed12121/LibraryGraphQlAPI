using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQL.API.Models
{
    public class Models
    {

    }
    public class Book
    {
        public int Id { get; set; }
        public string? Title { get; set; }

        public Author? Author { get; set; }
    }

    public class Author
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}