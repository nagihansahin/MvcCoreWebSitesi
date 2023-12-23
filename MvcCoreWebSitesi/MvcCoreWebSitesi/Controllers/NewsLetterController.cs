using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace MvcCoreWebSitesi.Controllers
{
    public class NewsLetterController : Controller
    {
        NewsLetterManager nm = new NewsLetterManager(new EfNewsLetterRepository());
        [HttpGet]
        public IActionResult SubsribeMail()
        {
            return PartialView();
        }
        [HttpPost]
        public IActionResult SubsribeMail(NewsLetter p)
        {
            p.MailStatus = true;
            nm.AddNewsLetter(p);
            Response.Redirect("/Blog/Index/");
            return PartialView();
        }
    }
}
