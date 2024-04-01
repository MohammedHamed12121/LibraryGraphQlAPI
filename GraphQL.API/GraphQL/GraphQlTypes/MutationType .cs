using GraphQL.API.GraphQL.Types;

namespace GraphQL.API.GraphQL.QueryTypes
{
    public class MutationType : ObjectType<Mutation>
    {
        protected override void Configure(IObjectTypeDescriptor<Mutation> descriptor)
        {
            descriptor
                .Field(f => f.AddSBook(default!))
                .Type<ListType<SBookType>>();

            descriptor
                .Field(f => f.DeleteSBook(default!))
                .Type<ListType<SBookType>>();
                
            descriptor
                .Field(f => f.UpdateSBook(default!, default!))
                .Type<SBookType>();
        }
    }
}