using Abp.AspNetCore.Mvc.ViewComponents;

namespace TakTikan.Tailor.Web.Public.Views
{
    public abstract class TailorViewComponent : AbpViewComponent
    {
        protected TailorViewComponent()
        {
            LocalizationSourceName = TailorConsts.LocalizationSourceName;
        }
    }
}