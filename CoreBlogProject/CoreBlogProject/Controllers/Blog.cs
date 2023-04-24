using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlogProject.Controllers
{
    public class Blog : Controller
    {
        BlogManager bm = new BlogManager(new EFBlogDal());
        WriterManager wm = new WriterManager(new EFWriterDal());
        NewsLetterManager nl = new NewsLetterManager(new EFNewsLetterDal());
        CommentManager cm = new CommentManager(new EFCommentDal());
        public IActionResult Index()
        {
            var x = bm.GetBlogListWithCategory();
            return View(x);
        }

        public IActionResult BlogDetail(int id)
        {
            ViewBag.id = id;
            var x = wm.IDGetir(bm.YazarIDGetir(id));
            ViewBag.yazar = x.WriterName;
            return View(bm.IDListele(id));
        }

        public IActionResult MailGonder(NewsLetter w)
        {
            w.MailStatus = true;
            nl.TEkle(w);
            return RedirectToAction("Index");
        }
        public IActionResult YorumGonder(EntityLayer.Concrete.Comment d)
        {
            d.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            d.CommentStatus = true;
            cm.TEkle(d);
            return RedirectToAction("Index");
        }
    }
}
