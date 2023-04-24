using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }
        public Comment IDGetir(int id)
        {
            return _commentDal.IDBul(id);
        }

        public List<Comment> IDListele(int id)
        {
            return _commentDal.IDListele(b => b.CommentID == id);
        }

        public List<Comment> Listele()
        {
            return _commentDal.Listele();
        }

        public void TEkle(Comment t)
        {
            _commentDal.Ekle(t);
        }

        public void TGuncelle(Comment t)
        {
            _commentDal.Guncelle(t);
        }

        public void TSil(Comment t)
        {
            _commentDal.Sil(t);
        }

        public List<Comment> CommentByBlog(int id)
        {
            return _commentDal.IDListele(b => b.BlogID == id);
        }
    }
}
