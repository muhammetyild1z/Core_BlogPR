using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
  public  class CatagoryManager : ICatagoryServices
    {
        ICatagoryDal _ICatgoryDal;
        Context c = new Context();
        //çağırma publkic
        public CatagoryManager(ICatagoryDal catagoryDal)
        {
            _ICatgoryDal = catagoryDal;
        }

        public void Add(Catagory t)
        {
            _ICatgoryDal.Insert(t);
        }

        public void Delete(Catagory t)
        {
            _ICatgoryDal.Delete(t);
        }

        public void Update(Catagory t)
        {
            _ICatgoryDal.Update(t);
        }

        public List<Catagory> GetByID(int id)
        {
            return _ICatgoryDal.GetListAll();
        }

        public List<Catagory> GetList()
        {
            return _ICatgoryDal.GetListAll();
        }

        public List<Catagory> GetBlogAndCatagoryList()
        {
            throw new NotImplementedException();
        }

        public List<Catagory> GetBlogAndByWriter(int id)
        {
            throw new NotImplementedException();
        }

        public List<Catagory> GetLista(int id)
        {
            throw new NotImplementedException();
        }

        public List<Catagory> GetCatagoryandBlog()
        {
            return _ICatgoryDal.GetListAll();
        }

        //public List<Catagory> getcatagoryleftList(int id)
        //{
        //    return _ICatgoryDal.GetListAll();
        //}
    }
}
