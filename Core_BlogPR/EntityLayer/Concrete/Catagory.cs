using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class Catagory
    {
        [Key]
        public int catagoryID { get; set; }

        public string catagoryName { get; set; }

        public string catagoryDesc { get; set; }

        public bool catagoryStatus { get; set; }

       public List<Blog> Blogs { get; set; }

     
    }
}
