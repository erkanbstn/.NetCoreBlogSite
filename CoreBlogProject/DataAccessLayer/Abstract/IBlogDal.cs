using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IBlogDal : IGenericDal<Blog>
    {
        List<Blog> GetListWithCategory();
        public List<Blog> AzListele(int id);
        public int YazarBilgiGetir(int id);
        public List<Blog> YazarBlogGetir(int id);
        public List<Blog> SonBlog();

    }
}
