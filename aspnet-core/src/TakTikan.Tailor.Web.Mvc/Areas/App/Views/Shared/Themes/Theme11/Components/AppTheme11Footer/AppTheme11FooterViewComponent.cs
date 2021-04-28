using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TakTikan.Tailor.Web.Areas.App.Models.Layout;
using TakTikan.Tailor.Web.Session;
using TakTikan.Tailor.Web.Views;

namespace TakTikan.Tailor.Web.Areas.App.Views.Shared.Themes.Theme11.Components.AppTheme11Footer
{
    public class AppTheme11FooterViewComponent : TailorViewComponent
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public AppTheme11FooterViewComponent(IPerRequestSessionCache sessionCache)
        {
            _sessionCache = sessionCache;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var footerModel = new FooterViewModel
            {
                LoginInformations = await _sessionCache.GetCurrentLoginInformationsAsync()
            };

            return View(footerModel);
        }
    }
}
