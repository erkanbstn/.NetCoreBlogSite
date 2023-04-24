using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BlogManager : IBlogService
    {
        IBlogDal _blogDal;
        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public List<Blog> GetBlogListWithCategory()
        {
            return _blogDal.GetListWithCategory();
        }

        public Blog IDGetir(int id)
        {
            return _blogDal.IDBul(id);
        }

        public List<Blog> IDListele(int id)
        {
            return _blogDal.IDListele(b => b.BlogID == id);
        }

        public List<Blog> Listele()
        {
            return _blogDal.Listele();
        }

        public void TEkle(Blog t)
        {
            _blogDal.Ekle(t);
        }

        public void TGuncelle(Blog t)
        {
            _blogDal.Guncelle(t);
        }

        public void TSil(Blog t)
        {
            _blogDal.Sil(t);
        }
        public List<Blog> AzListele(int id)
        {
            return _blogDal.AzListele(id);
        }

        public int YazarIDGetir(int id)
        {
            return _blogDal.YazarBilgiGetir(id);
        }

        public List<Blog> SonBlog()
        {
            return _blogDal.SonBlog();
        }

        public List<Blog> YazarBlogGetir(int id)
        {
            return _blogDal.YazarBlogGetir(id);
        }
    }
}
