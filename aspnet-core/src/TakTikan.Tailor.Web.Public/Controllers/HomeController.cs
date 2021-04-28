using Microsoft.AspNetCore.Mvc;
using TakTikan.Tailor.Web.Controllers;

namespace TakTikan.Tailor.Web.Public.Controllers
{
    public class HomeController : TailorControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}