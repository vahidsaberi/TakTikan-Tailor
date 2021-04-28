using Abp.Modules;
using Abp.Reflection.Extensions;

namespace TakTikan.Tailor
{
    public class TailorCoreSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TailorCoreSharedModule).GetAssembly());
        }
    }
}