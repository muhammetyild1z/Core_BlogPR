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
    public class INewsLatterManager : INewsLatterServices
    {
        INewsLatterDal _newsLatterDal;

        public INewsLatterManager(INewsLatterDal newsLatterDal)
        {
            _newsLatterDal = newsLatterDal;
        }
   
        public void Add(NewsLatter newsLatter)
        {
            _newsLatterDal.Insert(newsLatter);
        }

        public void Delete(NewsLatter t)
        {
            throw new NotImplementedException();
        }

        public List<NewsLatter> GetBlogAndByWriter(int id)
        {
            throw new NotImplementedException();
        }

        public List<NewsLatter> GetBlogAndCatagoryList()
        {
            throw new NotImplementedException();
        }

        public List<NewsLatter> GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<NewsLatter> GetList()
        {
            throw new NotImplementedException();
        }

        public List<NewsLatter> GetLista(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(NewsLatter t)
        {
            throw new NotImplementedException();
        }
    }
}
