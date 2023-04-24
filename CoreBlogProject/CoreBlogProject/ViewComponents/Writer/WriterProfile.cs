using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlogProject.ViewComponents.Writer
{
    public class WriterProfile:ViewComponent
    {
        WriterManager wm = new WriterManager(new EFWriterDal());
        public IViewComponentResult Invoke()
        {
            int id = Convert.ToInt32(User.Identity.Name);
            return View(wm.IDListele(id));
        }
    }
}
