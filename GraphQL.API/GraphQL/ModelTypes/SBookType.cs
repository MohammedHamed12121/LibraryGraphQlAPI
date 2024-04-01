using GraphQL.API.Models;

namespace GraphQL.API.GraphQL.Types
{
    public class SBookType : ObjectType<SBook>
    {
        protected override void Configure(IObjectTypeDescriptor<SBook> descriptor)
        {
            descriptor
                .Field(f => f.Title)
                .Type<StringType>();

            descriptor
                .Field(f => f.Author)
                .Type<AuthorType>();
        }

    }
}