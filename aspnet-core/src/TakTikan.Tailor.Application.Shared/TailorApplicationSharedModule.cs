using Abp.Modules;
using Abp.Reflection.Extensions;

namespace TakTikan.Tailor
{
    [DependsOn(typeof(TailorCoreSharedModule))]
    public class TailorApplicationSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TailorApplicationSharedModule).GetAssembly());
        }
    }
}