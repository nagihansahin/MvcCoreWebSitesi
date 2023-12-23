using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace MvcCoreWebSitesi.ViewComponents.Category
{
    public class CategoryList:ViewComponent
    {
        CategoryManager cm=new CategoryManager(new EfCategoryRepository());
        public IViewComponentResult Invoke()
        {
            var values=cm.GetList();
            return View(values);
        }
    }
}
