using Abp.Modules;
using Abp.Reflection.Extensions;

namespace TakTikan.Tailor
{
    [DependsOn(typeof(TailorXamarinSharedModule))]
    public class TailorXamarinIosModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TailorXamarinIosModule).GetAssembly());
        }
    }
}