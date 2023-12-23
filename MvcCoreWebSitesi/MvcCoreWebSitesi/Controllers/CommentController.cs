using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace MvcCoreWebSitesi.Controllers
{
    public class CommentController : Controller
    {
        CommentManager cm=new CommentManager(new EfCommentRepository());
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        //Yorum Ekleme kısmı:
        public PartialViewResult PartialAddComment()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult PartialAddComment(Comment c)
        {
            c.CommentDate=DateTime.Parse(DateTime.Now.ToShortDateString());
            c.CommentStatus = true;
            c.BlogID = 5;
            cm.CommentAdd(c);
            Response.Redirect("/Blog/Index/");
            return PartialView();
        }
        //Yorumların gözüktüğü kısım:
        public PartialViewResult CommenntListByBlog(int id)
        {
            var values = cm.GetList(id);
            return PartialView(values);
        }
    }
}
