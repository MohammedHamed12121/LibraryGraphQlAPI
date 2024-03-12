using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.API.GraphQL.Types;
using HotChocolate.Types;

namespace GraphQL.API.GraphQL.QueryTypes
{
    public class QueryType : ObjectType<Query>
    {
        protected override void Configure(IObjectTypeDescriptor<Query> descriptor)
        {
            descriptor
                .Field(f => f.GetBooks())
                .Type<ListType<BookType>>();
        }
    }
}