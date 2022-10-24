using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class Writer
    {
        [Key]
        public int writerID { get; set; }
        public string writerName { get; set; }
        public string writerAbout { get; set; }
        public string writerImage { get; set; }
        public string mail { get; set; }
        public string password { get; set; }
        public bool writerStatus { get; set; }
        public List<Blog> Blogs { get; set; }

       // public int TodoID { get; set; }

      //  public Todo todo { get; set; }
    }
}
