using Abp.Modules;
using Abp.Reflection.Extensions;

namespace TakTikan.Tailor
{
    public class TailorClientModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TailorClientModule).GetAssembly());
        }
    }
}
