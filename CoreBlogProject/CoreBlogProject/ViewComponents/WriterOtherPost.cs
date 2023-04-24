using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlogProject.ViewComponents
{
    public class WriterOtherPost: ViewComponent
    {
        BlogManager bm = new BlogManager(new EFBlogDal());
        WriterManager wm = new WriterManager(new EFWriterDal());
        public IViewComponentResult Invoke(int id)
        {
            var x = wm.IDGetir(bm.YazarIDGetir(id));
            return View(bm.AzListele(x.WriterID));
        }
    }
}
