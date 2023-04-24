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
   public  class WriterManager  : IWriterService
    {
        IWriterDal _WriterDal;

        public WriterManager(IWriterDal WriterDal)
        {
            _WriterDal = WriterDal;
        }
        public Writer IDGetir(int id)
        {
            return _WriterDal.IDBul(id);
        }

        public List<Writer> IDListele(int id)
        {
            return _WriterDal.IDListele(b => b.WriterID == id);
        }

        public List<Writer> Listele()
        {
            return _WriterDal.Listele();
        }
       

        public void TEkle(Writer t)
        {
            _WriterDal.Ekle(t);
        }

        public void TGuncelle(Writer t)
        {
            _WriterDal.Guncelle(t);
        }

        public void TSil(Writer t)
        {
            _WriterDal.Sil(t);
        }

        public Writer WriterLogin(Writer w)
        {
            return _WriterDal.WriterLogin(w);
        }
    }
}
