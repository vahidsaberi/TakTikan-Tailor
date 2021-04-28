using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TakTikan.Tailor.Web.Areas.App.Models.Layout;
using TakTikan.Tailor.Web.Session;
using TakTikan.Tailor.Web.Views;

namespace TakTikan.Tailor.Web.Areas.App.Views.Shared.Themes.Theme6.Components.AppTheme6Brand
{
    public class AppTheme6BrandViewComponent : TailorViewComponent
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public AppTheme6BrandViewComponent(IPerRequestSessionCache sessionCache)
        {
            _sessionCache = sessionCache;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var headerModel = new HeaderViewModel
            {
                LoginInformations = await _sessionCache.GetCurrentLoginInformationsAsync()
            };

            return View(headerModel);
        }
    }
}
