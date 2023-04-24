using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CoreBlogProject.Controllers
{
    [AllowAnonymous]
    public class WriterPanel : Controller
    {
        WriterManager wm = new WriterManager(new EFWriterDal());
        WriterValidate wv = new WriterValidate();
        public IActionResult WriterRegister()
        {
            return View();
        }
        [HttpPost]
        public IActionResult WriterRegister(EntityLayer.Concrete.Writer w, IFormFile file)
        {

            if (file == null || file.Length == 0 || file.Length < 0)
            {
                ViewBag.kayit = "Resim Dosyası Yüklemediniz";
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

            wm.TEkle(w);

            ViewBag.kayit = "Sisteme Başarıyla Kayıt Olundu, Giriş Yapabilirsiniz.";
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(EntityLayer.Concrete.Writer w)
        {
            var x = wm.WriterLogin(w);
            if (x != null)
            {
                var claim = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,  x.WriterID.ToString()),
                };
                var useridentity = new ClaimsIdentity(claim, "a");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                //HttpContext.Session.SetString("UserMail", x.WriterMail);
                return RedirectToAction("Index", "Writer");
            }
            else
            {
                return View();
            }
        }
    }
}
