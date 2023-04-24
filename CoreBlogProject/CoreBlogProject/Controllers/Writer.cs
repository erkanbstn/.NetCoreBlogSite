using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using FluentValidation.Results;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlogProject.Controllers
{
    public class Writer : Controller
    {
        BlogManager bm = new BlogManager(new EFBlogDal());
        CategoryManager cm = new CategoryManager(new EFCategoryDal());
        WriterManager wm = new WriterManager(new EFWriterDal());
        NotificationManager nm = new NotificationManager(new EFNotificationDal());
        BlogValidate bv = new BlogValidate();
        WriterValidate wv = new WriterValidate();
        public IActionResult Index()
        {
            var x = Convert.ToInt32(User.Identity.Name);
            return View(bm.YazarBlogGetir(x));
        }
        public PartialViewResult WriterNavBar()
        {
            return PartialView();
        }
        public PartialViewResult WriterFooter()
        {
            return PartialView();
        }

        public IActionResult BlogList()
        {
            return View();
        }

        public IActionResult AddBlog()
        {
            ViewBag.kategori = cm.DropDownCategory();
            return View();
        }
        [HttpPost]
        public IActionResult AddBlog(EntityLayer.Concrete.Blog t)
        {
            var x = Convert.ToInt32(User.Identity.Name);
            ValidationResult vr = bv.Validate(t);
            if (vr.IsValid)
            {
                t.WriterID = x;
                t.CreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                t.BlogStatus = true;
                bm.TEkle(t);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var i in vr.Errors)
                {
                    ModelState.AddModelError(i.PropertyName, i.ErrorMessage);
                }
                return View();
            }
        }
        public IActionResult DeleteBlog(int id)
        {
            bm.TSil(bm.IDGetir(id));
            return RedirectToAction("Index");
        }
        public IActionResult UpdateBlog(int id)
        {
            ViewBag.kategori = cm.DropDownCategory();
            return View(bm.IDGetir(id));
        }
        [HttpPost]
        public IActionResult UpdateBlog(EntityLayer.Concrete.Blog t)
        {
            ValidationResult vr = bv.Validate(t);
            if (vr.IsValid)
            {
                bm.TGuncelle(t);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var i in vr.Errors)
                {
                    ModelState.AddModelError(i.PropertyName, i.ErrorMessage);
                }
                return View();
            }
        }
        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Blog");
        }

        public IActionResult MyProfile()
        {
            var x = Convert.ToInt32(User.Identity.Name);
            ViewBag.writerid = wm.IDGetir(x);
            return View(wm.IDGetir(x));
        }
        [HttpPost]
        public IActionResult MyProfile(EntityLayer.Concrete.Writer w, IFormFile file)
        {
            if (file == null || file.Length == 0 || file.Length < 0)
            {
                w.WriterStatus = true;
                wm.TGuncelle(w);
                return View();
            }
            var uzanti = Path.GetExtension(file.FileName).Trim('.').ToLower();

            if (!(new[] { "jpg", "png", "jpeg" }).Contains(uzanti))
            {
                ViewBag.kayit = "Yalnızca jpg, png ve jpeg Tipinde Dosya Yükleyebilirsiniz";
                return View();
            }
            var klasor = $"wwwroot/WebLog/images";
            var dosyayolu = $"{klasor}/{file.FileName}";

            if (!Directory.Exists(Path.Combine(klasor)))
            {
                Directory.CreateDirectory(Path.Combine(klasor));
            }

            using (Stream filestream = new FileStream(dosyayolu, FileMode.Create))
            {
                file.CopyTo(filestream);
            }

            w.WriterImage = $"{file.FileName}";
            w.WriterStatus = true;
            ValidationResult vr = wv.Validate(w);
            wm.TGuncelle(w);
            return RedirectToAction("Index");
        }
        public IActionResult WriterNotification()
        {
            return View(nm.Listele());
        }
    }
}
