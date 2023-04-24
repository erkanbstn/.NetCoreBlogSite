using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlogProject.ViewComponents
{
    public class UserFooter : ViewComponent
    {
        BlogManager bm = new BlogManager(new EFBlogDal());
        public IViewComponentResult Invoke()
        {
            return View(bm.AzListele(1));
        }
    }
}
