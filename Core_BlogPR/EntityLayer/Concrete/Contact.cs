using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
 public   class Contact
    {
        [Key]
        public int contactID { get; set; }

        public string contactUserName { get; set; }

        public string contactMail { get; set; }

        public string contactBaslik { get; set; }

        public string contactMessage { get; set; }

        public DateTime contactDate { get; set; }

        public bool contactStatus { get; set; }
    }
}
