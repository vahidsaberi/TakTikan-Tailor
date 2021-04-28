using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace TakTikan.Tailor
{
    [DependsOn(typeof(TailorClientModule), typeof(AbpAutoMapperModule))]
    public class TailorXamarinSharedModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Localization.IsEnabled = false;
            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TailorXamarinSharedModule).GetAssembly());
        }
    }
}