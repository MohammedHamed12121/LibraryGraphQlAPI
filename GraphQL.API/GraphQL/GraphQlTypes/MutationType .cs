using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.API.GraphQL.Types;
using GraphQL.API.Models;

namespace GraphQL.API.GraphQL.QueryTypes
{
    public class MutationType : ObjectType<Mutation>
    {
        protected override void Configure(IObjectTypeDescriptor<Mutation> descriptor)
        {
            descriptor
                .Field(f => f.AddBook(default))
                .Type<ListType<BookType>>();
            descriptor
                .Field(f => f.DeleteBook(default))
                .Type<ListType<BookType>>();
            descriptor
                .Field(f => f.UpdateBook(default,default))
                .Type<BookType>();
        }
    }
}