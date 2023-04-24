using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;
namespace CoreBlogProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EFCategoryDal());
        public IActionResult Index(int page = 1)
        {
            return View(cm.Listele().ToPagedList(page, 3));
        }
        public IActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCategory(Category c)
        {
            c.CategoryStatus = true;
            cm.TEkle(c);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteCategory(int id)
        {
            cm.TSil(cm.IDGetir(id));
            return RedirectToAction("Index");
        }
        public IActionResult EditCategory(int id)
        {
            return View(cm.IDGetir(id));
        }
        [HttpPost]
        public IActionResult EditCategory(Category c)
        {
            c.CategoryStatus = true;
            cm.TGuncelle(c);
            return RedirectToAction("Index");
        }
    }
}
