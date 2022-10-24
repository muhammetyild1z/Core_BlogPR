using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IBlogDal:IGenericDal<Blog>
    {
        List<Blog> GetWithCatagory();
        List<Blog> GetWithCatagoryByWriter(int id);
        List<Blog> GetWithWriter();
        List<Blog> GetWriterAndCatagoryAndBlog();
        List<Blog> GetblogandCatagories();
        

    }
}
