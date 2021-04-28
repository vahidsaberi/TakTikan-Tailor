using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using TakTikan.Tailor.Web.Controllers;

namespace TakTikan.Tailor.Web.Areas.App.Controllers
{
    [Area("App")]
    [AbpMvcAuthorize]
    public class WelcomeController : TailorControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}