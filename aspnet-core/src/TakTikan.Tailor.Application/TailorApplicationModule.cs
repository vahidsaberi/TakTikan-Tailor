using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TakTikan.Tailor.Authorization;

namespace TakTikan.Tailor
{
    /// <summary>
    /// Application layer module of the application.
    /// </summary>
    [DependsOn(
        typeof(TailorApplicationSharedModule),
        typeof(TailorCoreModule)
        )]
    public class TailorApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            //Adding authorization providers
            Configuration.Authorization.Providers.Add<AppAuthorizationProvider>();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TailorApplicationModule).GetAssembly());
        }
    }
}