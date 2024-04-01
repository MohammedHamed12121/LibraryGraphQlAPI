using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace GraphQL.API.Models
{
    public class Models
    {

    }
    public class SBook
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
    public class Book
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        [BsonElement("ISBN")]
        public string? ISBN { get; set; }
        [BsonElement("Book-Title")]
        public string? BookTitle { get; set; }
        [BsonElement("Book-Author")]
        public string? BookAuthor { get; set; }
        [BsonElement("Year-Of-Publication")]
        public string? YearOfPublication { get; set; }
        [BsonElement("Publisher")]
        public string? Publisher { get; set; }
        [BsonElement("Image-URL-S")]
        public string? ImageURLSmall { get; set; }
        [BsonElement("Image-URL-M")]
        public string? ImageURLMideum { get; set; }
        [BsonElement("Image-URL-L")]
        public string? ImageURLLarge { get; set; }
    }
}