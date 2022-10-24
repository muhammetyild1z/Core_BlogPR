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
    public class WriterManager : IWriterServices
    {
        IWriterDal _writerDal;

        public WriterManager(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }

        public void Add(Writer writer)
        {
            _writerDal.Insert(writer);

        }

        public void Delete(Writer t)
        {
            throw new NotImplementedException();
        }

        public List<Writer> GetBlogAndByWriter(int id)
        {
            throw new NotImplementedException();
        }

        public List<Writer> GetBlogAndCatagoryList()
        {
            throw new NotImplementedException();
        }

        public List<Writer> GetByID()
        {
            throw new NotImplementedException();
        }

        public Writer GetByID(int id)
        {
          return _writerDal.GetByID(id);
        }

        public List<Writer> GetList()
        {
            return _writerDal.GetListAll();
        }

        public List<Writer> GetLista(string p)
        {
            return _writerDal.GetListAll(x => x.writerName.Contains(p));
        }

        public List<Writer> GetLista(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Writer t)
        {
            _writerDal.Update(t);
            
        }

        List<Writer> IGenericServices<Writer>.GetByID(int id)
        {
            throw new NotImplementedException();
        }
    }
}
