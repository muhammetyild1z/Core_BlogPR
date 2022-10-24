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
    public class BlogManager:IBlogServices
    {
        IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public void Add(Blog t)
        {
            _blogDal.Insert(t);
        }

        public void Delete(Blog t)
        {
            _blogDal.Delete(t);
        }
        public void Update(Blog t)
        {
            _blogDal.Update(t);
        }
        // arama yapmak için input name ile controllerde bi string ifade yarat 
        //sonra tüm listeyi getirip contains methodu ile ara
        //ekstra bir controller tanımlamaya gerek yok tüm listeyi getirdiğin bi controllerde işlem yapılır.
        public List<Blog> GetLista(string p)
        {
            
          return  _blogDal.GetListAll(x=>x.blogTitle.Contains(p));
        }
       

        public List<Blog> GetBlogAndByWriter(int id)
        {
            var last4blog = _blogDal.GetListAll(x => x.writerID == id);

                return last4blog;
        }

        public List<Blog> GetWithCatagoryByWriterBM(int id)
        {
            var last4blog = _blogDal.GetWithCatagoryByWriter(id);

            return last4blog;
        }
    
        public List<Blog> GetBlogAndCatagoryList()
        {
            return _blogDal.GetWithCatagory();
        }

        public List<Blog> GetblogandCatagories()
        {
            return _blogDal.GetblogandCatagories();
            
        }

        public List<Blog> GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetList()
        {
            return _blogDal.GetListAll();
        }
        
        public List<Blog> GetLast3Post()
        {
            return _blogDal.GetListAll().Take(3).ToList();
        }

        public List<Blog> GetLast7DaysPost()
        {
            return _blogDal.GetListAll();
        }
        public List<Blog> GetLast4Post()
        {
            return _blogDal.GetListAll().Take(5).ToList();
           
        }

        
        public List<Blog> GetLast4PostWriter()
        {
            return _blogDal.GetWriterAndCatagoryAndBlog().Take(5).ToList();
        }

        public List<Blog> GetBlogByIDList(int id)
        {
           
           
            return _blogDal.GetListAll(x => x.blogID == id);
        }

        public List<Blog> GetListeWriter()
        {
            return _blogDal.GetWithWriter();
        }

        public List<Blog> GetLista(int id)
        {
            throw new NotImplementedException();
        }
    }
}
