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
    public class AdminManager : IAdminService
    {
        IAdminDal _Admin;

        public AdminManager(IAdminDal AdminDal)
        {
            _Admin = AdminDal;
        }

        public Admin IDGetir(int id)
        {
            return _Admin.IDBul(id);
        }

        public List<Admin> IDListele(int id)
        {
            return _Admin.IDListele(b => b.AdminID == id);
        }

        public List<Admin> Listele()
        {
            return _Admin.Listele();
        }

        public void TEkle(Admin t)
        {
            _Admin.Ekle(t);
        }

        public void TGuncelle(Admin t)
        {
            _Admin.Guncelle(t);
        }

        public void TSil(Admin t)
        {
            _Admin.Sil(t);
        }
    }
}
