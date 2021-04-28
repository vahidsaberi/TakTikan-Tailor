﻿using Microsoft.Extensions.DependencyInjection;
using TakTikan.Tailor.HealthChecks;

namespace TakTikan.Tailor.Web.HealthCheck
{
    public static class AbpZeroHealthCheck
    {
        public static IHealthChecksBuilder AddAbpZeroHealthCheck(this IServiceCollection services)
        {
            var builder = services.AddHealthChecks();
            builder.AddCheck<TailorDbContextHealthCheck>("Database Connection");
            builder.AddCheck<TailorDbContextUsersHealthCheck>("Database Connection with user check");
            builder.AddCheck<CacheHealthCheck>("Cache");

            // add your custom health checks here
            // builder.AddCheck<MyCustomHealthCheck>("my health check");

            return builder;
        }
    }
}
