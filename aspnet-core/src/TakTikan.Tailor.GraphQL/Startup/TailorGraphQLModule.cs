using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace TakTikan.Tailor.Startup
{
    [DependsOn(typeof(TailorCoreModule))]
    public class TailorGraphQLModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TailorGraphQLModule).GetAssembly());
        }

        public override void PreInitialize()
        {
            base.PreInitialize();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }
    }
}