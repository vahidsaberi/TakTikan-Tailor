using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Authorization;
using GraphQL;
using GraphQL.Types;
using Microsoft.EntityFrameworkCore;
using TakTikan.Tailor.Authorization;
using TakTikan.Tailor.Authorization.Roles;
using TakTikan.Tailor.Core.Base;
using TakTikan.Tailor.Core.Extensions;
using TakTikan.Tailor.Dto;
using TakTikan.Tailor.Types;

namespace TakTikan.Tailor.Queries
{
    public class RoleQuery : TailorQueryBase<ListGraphType<RoleType>, List<RoleDto>>
    {
        private readonly RoleManager _roleManager;

        public static class Args
        {
            public const string Id = "id";
            public const string TenantId = "tenantId";
            public const string Name = "name";
        }

        public RoleQuery(RoleManager roleManager)
            : base("roles", new Dictionary<string, Type>
                {
                    {Args.Id, typeof(IdGraphType)},
                    {Args.TenantId, typeof(IntGraphType)},
                    {Args.Name, typeof(StringGraphType)}
                }
            )
        {
            _roleManager = roleManager;
        }

        [AbpAuthorize(AppPermissions.Pages_Administration_Roles)]
        public override async Task<List<RoleDto>> Resolve(IResolveFieldContext context)
        {
            var query = _roleManager.Roles.AsNoTracking();

            context
                .ContainsArgument<int>(Args.Id, id => query = query.Where(r => r.Id == id))
                .ContainsArgument<string>(Args.TenantId, name => query = query.Where(r => r.Name == name))
                .ContainsArgument<int?>(Args.Name, tenantId => query = query.Where(r => r.TenantId == tenantId.Value));

            return await ProjectToListAsync<RoleDto>(query);
        }
    }
}
