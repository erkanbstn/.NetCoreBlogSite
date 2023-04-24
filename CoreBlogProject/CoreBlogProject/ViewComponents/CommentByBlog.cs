using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlogProject.ViewComponents
{
    public class CommentByBlog : ViewComponent
    {
        CommentManager cm = new CommentManager(new EFCommentDal());

        public IViewComponentResult Invoke(int id)
        {
            return View(cm.CommentByBlog(id)); 
        }
    }
}
