using Microsoft.AspNetCore.Mvc;
using TakTikan.Tailor.Web.Controllers;

namespace TakTikan.Tailor.Web.Public.Controllers
{
    public class AboutController : TailorControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}