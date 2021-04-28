using Abp.Modules;
using Abp.Reflection.Extensions;
using Castle.Windsor.MsDependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using TakTikan.Tailor.Configure;
using TakTikan.Tailor.Startup;
using TakTikan.Tailor.Test.Base;

namespace TakTikan.Tailor.GraphQL.Tests
{
    [DependsOn(
        typeof(TailorGraphQLModule),
        typeof(TailorTestBaseModule))]
    public class TailorGraphQLTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            IServiceCollection services = new ServiceCollection();
            
            services.AddAndConfigureGraphQL();

            WindsorRegistrationHelper.CreateServiceProvider(IocManager.IocContainer, services);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TailorGraphQLTestModule).GetAssembly());
        }
    }
}