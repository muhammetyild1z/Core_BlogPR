using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T:class
    {
        void Insert(T t);
        void Update(T t);
        void Delete(T t);

        List<T> GetListAll();
        //istenilen bir parametreye göre sıramala yapılacaksa değer alır
        // List<T> GetListAll(T t);
        T GetByID(int id);
        /// Şartlı listeleme
        List<T> GetListAll(Expression<Func<T, bool>> filter);
        Expression<Func<T, int>> ToExpressionOfFunc(Expression<Action<T>> filters);


    }
}
