using GraphQL.API.Models;

namespace GraphQL.API.GraphQL.Types
{
    public class AuthorType : ObjectType<Author>
    {
        protected override void Configure(IObjectTypeDescriptor<Author> descriptor)
        {
            descriptor
                .Field(f=>f.Name)
                .Type<StringType>();
        }
    }
}