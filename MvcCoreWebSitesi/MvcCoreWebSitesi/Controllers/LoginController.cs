using Microsoft.AspNetCore.Mvc;

namespace MvcCoreWebSitesi.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
