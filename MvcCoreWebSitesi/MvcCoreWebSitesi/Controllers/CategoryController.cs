using Microsoft.AspNetCore.Mvc;

namespace MvcCoreWebSitesi.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
