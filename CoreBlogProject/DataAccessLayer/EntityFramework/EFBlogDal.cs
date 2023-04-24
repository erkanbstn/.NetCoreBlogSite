using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.EntityFramework
{
    public class EFBlogDal : GenericRepository<Blog>, IBlogDal
    {
        public List<Blog> GetListWithCategory()
        {
            using (var c = new Context())
            {
                return c.Blogs.Include(x => x.Category).ToList();
            }
        }

        public List<Blog> AzListele(int id)
        {
            using (var c = new Context())
            {
                return c.Blogs.Where(b => b.WriterID == id).Take(2).ToList();
            }
        }

        public int YazarBilgiGetir(int id)
        {
            using (var c = new Context())
            {
                return c.Blogs.Where(b => b.BlogID == id).Select(n => n.WriterID).FirstOrDefault();
            }
        }

        public List<Blog> YazarBlogGetir(int id)
        {
            using (var c = new Context())
            {
                return c.Blogs.Include(b => b.Category).Where(b => b.WriterID == id).ToList();
            }
        }
        public List<Blog> SonBlog()
        {
            using (var c = new Context())
            {
                return c.Blogs.OrderByDescending(b => b.BlogID).Take(1).ToList();
            }
        }
    }
}
