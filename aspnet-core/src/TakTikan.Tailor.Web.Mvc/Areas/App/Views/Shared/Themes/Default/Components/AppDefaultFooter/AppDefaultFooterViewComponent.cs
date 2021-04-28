using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TakTikan.Tailor.Web.Areas.App.Models.Layout;
using TakTikan.Tailor.Web.Session;
using TakTikan.Tailor.Web.Views;

namespace TakTikan.Tailor.Web.Areas.App.Views.Shared.Themes.Default.Components.AppDefaultFooter
{
    public class AppDefaultFooterViewComponent : TailorViewComponent
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public AppDefaultFooterViewComponent(IPerRequestSessionCache sessionCache)
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
