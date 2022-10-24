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
    public class MessageManager : IMessageServices
    {
        IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public void Add(Message t)
        {
            throw new NotImplementedException();
        }

        public void Delete(Message t)
        {
            throw new NotImplementedException();
        }

        public List<Message> GetBlogAndByWriter(int id)
        {
            throw new NotImplementedException();
        }

        public List<Message> GetBlogAndCatagoryList()
        {
            throw new NotImplementedException();
        }

        public List<Message> GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Message> GetInboxListbyWriter(string p)
        {
            //receiver alıcı bizsek return
            return _messageDal.GetListAll(x => x.Receiver == p);
        }

        public List<Message> GetList()
        {
            throw new NotImplementedException();
        }

        public List<Message> GetLista(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Message t)
        {
            throw new NotImplementedException();
        }
    }
}
