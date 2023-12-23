using Microsoft.AspNetCore.Mvc;
using MvcCoreWebSitesi.Models;
using System.Collections.Generic;

namespace MvcCoreWebSitesi.ViewComponents
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentValues = new List<UserComment>
            {
                new UserComment
                {
                    ID = 1,
                    UserName="Nagihan"
                },
                   new UserComment
                {
                    ID = 2,
                    UserName="Derya"
                }
            };
            return View(commentValues);
        }
    }
}
