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
   public class AboutManager:IAboutServices
    {
        IAboutDal _aboutdal;

        public AboutManager(IAboutDal aboutdal)
        {
            _aboutdal = aboutdal;
        }

        public void Add(About t)
        {
            throw new NotImplementedException();
        }

        public void Delete(About t)
        {
            throw new NotImplementedException();
        }

        public List<About> GetBlogAndByWriter(int id)
        {
            throw new NotImplementedException();
        }

        public List<About> GetBlogAndCatagoryList()
        {
            throw new NotImplementedException();
        }

        public List<About> GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<About> GetList()
        {
           return _aboutdal.GetListAll();
        }

        public List<About> GetLista(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(About t)
        {
            throw new NotImplementedException();
        }
    }
}
