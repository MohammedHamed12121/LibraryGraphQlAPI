using GraphQL.API.GraphQL.Types;

namespace GraphQL.API.GraphQL.QueryTypes
{
    public class QueryType : ObjectType<Query>
    {
        protected override void Configure(IObjectTypeDescriptor<Query> descriptor)
        {
            descriptor
                .Field(f => f.GetSBooks())
                .Type<ListType<SBookType>>();
        }
    }
}