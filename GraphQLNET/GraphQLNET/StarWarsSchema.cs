using GraphQL.Types;
using GraphQL.Utilities;
using System;

namespace GraphQLNET
{
    public class StarWarsSchema : Schema
    {
        public StarWarsSchema(IServiceProvider resolveType)
            : base(resolveType)
        {
            Query = resolveType.GetRequiredService<StarWarsQuery>();

        }
    }
}
