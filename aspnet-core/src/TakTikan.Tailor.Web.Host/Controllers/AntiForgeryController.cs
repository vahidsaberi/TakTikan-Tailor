using Microsoft.AspNetCore.Antiforgery;

namespace TakTikan.Tailor.Web.Controllers
{
    public class AntiForgeryController : TailorControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
