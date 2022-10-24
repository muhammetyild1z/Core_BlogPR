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
    public class NotificationManager : INotificationServices
    {
        INotificationDal _notificationDal;

        public NotificationManager(INotificationDal notificationDal)
        {
            _notificationDal = notificationDal;
        }

        public void Add(Notification t)
        {
            throw new NotImplementedException();
        }

        public void Delete(Notification t)
        {
            throw new NotImplementedException();
        }

        public List<Notification> GetBlogAndByWriter(int id)
        {
            throw new NotImplementedException();
        }

        public List<Notification> GetBlogAndCatagoryList()
        {
            throw new NotImplementedException();
        }

        public List<Notification> GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Notification> GetList()
        {
          return  _notificationDal.GetListAll();
        }

        public List<Notification> GetLista(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Notification t)
        {
            throw new NotImplementedException();
        }
    }
}
