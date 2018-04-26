using Microsoft.AspNetCore.Antiforgery;
using CoreCMS.Controllers;

namespace CoreCMS.Web.Host.Controllers
{
    public class AntiForgeryController : CoreCMSControllerBase
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
