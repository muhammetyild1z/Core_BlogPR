using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
  public  class NewsLatter
    {
        [Key]
        public int mailID { get; set; }

        public string   mail { get; set; }
       
        public bool  mailStatus { get; set; }
    }
}
