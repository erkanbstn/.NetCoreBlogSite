using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlogProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminController : Controller
    {
        AdminManager am = new AdminManager(new EFAdminDal());
        public IActionResult Index()
        {
            return View(am.Listele());
        }
        public IActionResult DeleteAdmin(int id)
        {
            am.TSil(am.IDGetir(id));
            return RedirectToAction("Index");
        }
        public IActionResult AddAdmin()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddAdmin(EntityLayer.Concrete.Admin a)
        {
            am.TEkle(a);
            return RedirectToAction("Index");
        }
        public IActionResult EditAdmin(int id)
        {
            return View(am.IDGetir(id));
        }
        [HttpPost]
        public IActionResult EditAdmin(EntityLayer.Concrete.Admin a)
        {
            am.TGuncelle(a);
            return RedirectToAction("Index");
        }
    }
}
