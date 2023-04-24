using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBlogService : IGenericService<Blog>
    {
        List<Blog> GetBlogListWithCategory();
        int YazarIDGetir(int id);
        public List<Blog> SonBlog();

        public List<Blog> YazarBlogGetir(int id);
    }
}
