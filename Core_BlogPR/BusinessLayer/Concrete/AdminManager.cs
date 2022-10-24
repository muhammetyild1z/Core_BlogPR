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
    public class AdminManager : IAdminServices
    {
        IAdminDal _adminDal;

        public AdminManager(IAdminDal adminDal)
        {
            _adminDal = adminDal;
        }

        public void Add(Admin t)
        {
            throw new NotImplementedException();
        }

        public void Delete(Admin t)
        {
            throw new NotImplementedException();
        }

        public List<Admin> GetBlogAndByWriter(int id)
        {
            throw new NotImplementedException();
        }

        public List<Admin> GetBlogAndCatagoryList()
        {
            throw new NotImplementedException();
        }

        public List<Admin> GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Admin> GetList()
        {
            return _adminDal.GetListAll();
        }

        public List<Admin> GetLista(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Admin t)
        {
            throw new NotImplementedException();
        }
    }
}
