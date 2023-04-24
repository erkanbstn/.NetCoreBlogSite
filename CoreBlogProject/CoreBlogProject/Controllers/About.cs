using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlogProject.Controllers
{
    public class About : Controller
    {
        AboutManager am = new AboutManager(new EFAboutDal());
        public IActionResult Index()
        {
            return View(am.Listele());
        }
    }
}
