using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
 public   class About
    {
        [Key]
        public int aboutID { get; set; }

        public string aboutDetails_1{ get; set; }

        public string aboutDetails_2 { get; set; }

        public string aboutImage_1 { get; set; }

        public string aboutImage_2 { get; set; }

        public string aboutMapLocation { get; set; }

        public bool aboutStatus { get; set; }
    }
}
