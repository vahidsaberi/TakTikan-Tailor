using Abp.Dependency;
using GraphQL.Types;
using GraphQL.Utilities;
using TakTikan.Tailor.Queries.Container;
using System;

namespace TakTikan.Tailor.Schemas
{
    public class MainSchema : Schema, ITransientDependency
    {
        public MainSchema(IServiceProvider provider) :
            base(provider)
        {
            Query = provider.GetRequiredService<QueryContainer>();
        }
    }
}