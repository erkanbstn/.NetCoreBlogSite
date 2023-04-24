using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DataAccessLayer.EntityFramework
{
    public class EFCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        public List<SelectListItem> DropDownCategory()
        {
            using (var c = new Context())
            {
                List<SelectListItem> category = (from d in c.Categories.ToList() select new SelectListItem { Text=d.CategoryName , Value=d.CategoryID.ToString()}).ToList();
                return category;
            }
        }
    }
}
