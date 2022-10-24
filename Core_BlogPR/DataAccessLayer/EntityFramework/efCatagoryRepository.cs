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
    public class efCatagoryRepository:GenericRepository<Catagory>,ICatagoryDal
    {
        //public List<Catagory> getcatagoryleftList(int id)
        //{
        //    Context c = new Context();
        //    return c.Catagoies.Include(x => x.Blogs).Where(y=> y.catagoryID==id).ToList();


        //}
    }
}
