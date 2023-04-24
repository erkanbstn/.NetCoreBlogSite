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
    public class NotificationManager : INotificationService
    {
        INotificationDal _NotificationDal;
        public NotificationManager(INotificationDal NotificationDal)
        {
            _NotificationDal = NotificationDal;
        }

        public Notification IDGetir(int id)
        {
            return _NotificationDal.IDBul(id);
        }

        public List<Notification> IDListele(int id)
        {
            return _NotificationDal.IDListele(b => b.NotificationID == id);
        }

        public List<Notification> Listele()
        {
            return _NotificationDal.Listele();
        }

        public void TEkle(Notification t)
        {
            _NotificationDal.Ekle(t);
        }

        public void TGuncelle(Notification t)
        {
            _NotificationDal.Guncelle(t);
        }

        public void TSil(Notification t)
        {
            _NotificationDal.Sil(t);
        }
    }
}
