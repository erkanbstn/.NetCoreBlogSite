using CoreBlogProject.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlogProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ChartllarController : Controller
    {
        // Chart ve Json işlemlerinin test edildiği controller
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult WriterList()
        {
            var json = JsonConvert.SerializeObject(writers);
            return Json(json);
        }
        public static List<Writer> writers = new List<Writer>
        {
            new Writer{
                ID=1,
                Name="Erkan"
            },
             new Writer{
                ID=2,
                Name="Öykü"
            } ,
            new Writer{
                ID=3,
                Name="Samet"
            }
        };



    }
}
