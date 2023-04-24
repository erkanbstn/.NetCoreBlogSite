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
    public class ContactManager : IContactService
    {
        IContactDal _ContactDal;
        public ContactManager(IContactDal ContactDal)
        {
            _ContactDal = ContactDal;
        }

        public Contact IDGetir(int id)
        {
            return _ContactDal.IDBul(id);
        }

        public List<Contact> IDListele(int id)
        {
            return _ContactDal.IDListele(b => b.ContactID == id);
        }

        public List<Contact> Listele()
        {
            return _ContactDal.Listele();
        }

        public void TEkle(Contact t)
        {
            _ContactDal.Ekle(t);
        }

        public void TGuncelle(Contact t)
        {
            _ContactDal.Guncelle(t);
        }

        public void TSil(Contact t)
        {
            _ContactDal.Sil(t);
        }
    }
}
