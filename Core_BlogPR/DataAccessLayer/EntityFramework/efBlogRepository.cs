using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class efBlogRepository : GenericRepository<Blog>, IBlogDal
    {
        public List<Blog> GetWithCatagory()
        {
            Context c = new Context();
            return c.Blogs.Include(x => x.Catagory).Include(z => z.Comments).ToList();
           

        }
        public List<Blog> GetblogandCatagories()
        {
            Context c = new Context();
            // her katagori sayısı kadar geliyor !!!!!!!
           

           return  c.Blogs.Include(x => x.Catagory).ToList();
           
        }



        public List<Blog> GetWithWriter()
        {
            Context c = new Context();
            return c.Blogs.Include(x => x.Writer).ToList();
        }
        public List<Blog> GetWithCatagoryByWriter(int id)
        {
            Context c = new Context();
            return c.Blogs.Include(x => x.Catagory).Where(x=> x.writerID==id).ToList();
        }
        
       
        public List<Blog> GetWriterAndCatagoryAndBlog()
        {
            
            Context c = new Context();
           return c.Blogs.Include(x => x.Catagory ).Include(y=> y.Writer).OrderByDescending(c=>c.blogCreateDate).Where(c=>c.blogCreateDate<=DateTime.Now).Take(5).ToList();
        }
    }
}
