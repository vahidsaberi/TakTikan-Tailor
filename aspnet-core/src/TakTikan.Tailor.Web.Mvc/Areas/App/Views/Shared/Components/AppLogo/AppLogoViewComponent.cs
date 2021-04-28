using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TakTikan.Tailor.Web.Areas.App.Models.Layout;
using TakTikan.Tailor.Web.Session;
using TakTikan.Tailor.Web.Views;

namespace TakTikan.Tailor.Web.Areas.App.Views.Shared.Components.AppLogo
{
    public class AppLogoViewComponent : TailorViewComponent
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public AppLogoViewComponent(
            IPerRequestSessionCache sessionCache
        )
        {
            _sessionCache = sessionCache;
        }

        public async Task<IViewComponentResult> InvokeAsync(string logoSkin = null, string logoClass = "")
        {
            var headerModel = new LogoViewModel
            {
                LoginInformations = await _sessionCache.GetCurrentLoginInformationsAsync(),
                LogoSkinOverride = logoSkin,
                LogoClassOverride = logoClass
            };

            return View(headerModel);
        }
    }
}
