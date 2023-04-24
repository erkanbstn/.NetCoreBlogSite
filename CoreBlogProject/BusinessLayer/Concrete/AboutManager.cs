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
    public class AboutManager : IAboutService
    {
        IAboutDal _AboutDal;
        public AboutManager(IAboutDal AboutDal)
        {
            _AboutDal = AboutDal;
        }

        public About IDGetir(int id)
        {
            return _AboutDal.IDBul(id);
        }

        public List<About> IDListele(int id)
        {
            return _AboutDal.IDListele(b => b.AboutID == id);
        }

        public List<About> Listele()
        {
            return _AboutDal.Listele();
        }

        public void TEkle(About t)
        {
            _AboutDal.Ekle(t);
        }

        public void TGuncelle(About t)
        {
            _AboutDal.Guncelle(t);
        }

        public void TSil(About t)
        {
            _AboutDal.Sil(t);
        }
    }
}
