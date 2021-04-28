using Abp.Modules;
using Abp.Reflection.Extensions;

namespace TakTikan.Tailor
{
    [DependsOn(typeof(TailorXamarinSharedModule))]
    public class TailorXamarinAndroidModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TailorXamarinAndroidModule).GetAssembly());
        }
    }
}