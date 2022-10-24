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
    public class ContactManager : IContactServices
    {
        IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void Add(Contact contact)
        {
            _contactDal.Insert(contact);
        }

        public void Delete(Contact t)
        {
            throw new NotImplementedException();
        }

        public List<Contact> GetBlogAndByWriter(int id)
        {
            throw new NotImplementedException();
        }

        public List<Contact> GetBlogAndCatagoryList()
        {
            throw new NotImplementedException();
        }

        public List<Contact> GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Contact> GetList()
        {
            throw new NotImplementedException();
        }

        public List<Contact> GetLista(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Contact t)
        {
            throw new NotImplementedException();
        }
    }
}
