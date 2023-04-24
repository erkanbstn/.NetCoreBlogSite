using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _category;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _category = categoryDal;
        }

        public List<SelectListItem> DropDownCategory()
        {
            return _category.DropDownCategory();
        }

        public Category IDGetir(int id)
        {
            return _category.IDBul(id);
        }

        public List<Category> IDListele(int id)
        {
            return _category.IDListele(b => b.CategoryID == id);
        }

        public List<Category> Listele()
        {
            return _category.Listele();
        }

        public void TEkle(Category t)
        {
            _category.Ekle(t);
        }

        public void TGuncelle(Category t)
        {
            _category.Guncelle(t);
        }

        public void TSil(Category t)
        {
            _category.Sil(t);
        }
    }
}
