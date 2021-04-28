using Abp.AspNetCore.Mvc.Views;

namespace TakTikan.Tailor.Web.Views
{
    public abstract class TailorRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected TailorRazorPage()
        {
            LocalizationSourceName = TailorConsts.LocalizationSourceName;
        }
    }
}
