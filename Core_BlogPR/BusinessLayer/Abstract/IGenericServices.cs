using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
   public interface IGenericServices<T>
    {
        void Add(T t);
        void Delete(T t);
        void Update(T t);
        List<T> GetByID(int id);
        List<T> GetList();
        List<T> GetBlogAndCatagoryList();
        List<T> GetBlogAndByWriter(int id);
        List<T> GetLista(int id);
    }
}
