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
    public class NewsLetterManager : INewsLetterService
    {
        INewsLetterDal _NewsLetterDal;

        public NewsLetterManager(INewsLetterDal NewsLetterDal)
        {
            _NewsLetterDal = NewsLetterDal;
        }
        public NewsLetter IDGetir(int id)
        {
            return _NewsLetterDal.IDBul(id);
        }

        public List<NewsLetter> IDListele(int id)
        {
            return _NewsLetterDal.IDListele(b => b.MailID == id);
        }

        public List<NewsLetter> Listele()
        {
            return _NewsLetterDal.Listele();
        }


        public void TEkle(NewsLetter t)
        {
            _NewsLetterDal.Ekle(t);
        }

        public void TGuncelle(NewsLetter t)
        {
            _NewsLetterDal.Guncelle(t);
        }

        public void TSil(NewsLetter t)
        {
            _NewsLetterDal.Sil(t);
        }
    }
}
