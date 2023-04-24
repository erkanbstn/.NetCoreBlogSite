using BusinessLayer.Concrete;
using ClosedXML.Excel;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CoreBlogProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EFBlogDal());
        public IActionResult Index()
        {
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=İstanbul&mode=xml&appid=2e60768492d88a8382c36494dad510d7";
            XDocument document = XDocument.Load(connection);
            ViewBag.sicaklik = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            return View(bm.Listele());
        }


        public IActionResult ExcelImport()
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Blog Listesi");
                worksheet.Cell(1, 1).Value = "Blog ID";
                worksheet.Cell(1, 2).Value = "Blog Başlık";

                int hucresayisi = 2;

                foreach (var bloglar in bm.Listele())
                {
                    worksheet.Cell(hucresayisi, 1).Value = bloglar.BlogTitle;
                    worksheet.Cell(hucresayisi, 2).Value = bloglar.BlogContent;
                    hucresayisi++;
                }
                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "BlogSiteListe.xlsx");
                }
            }
        }

    }
}
