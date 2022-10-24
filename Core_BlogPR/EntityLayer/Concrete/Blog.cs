using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Blog
    {
        [Key]
        public int blogID { get; set; }

        public string blogTitle { get; set; }

        public string blogContent { get; set; }

        public DateTime blogCreateDate { get; set; }

        public bool blogStatus { get; set; }

        public string blogThumbnailImage { get; set; }

        public string blogSmallImage { get; set; }

        public int catagoryID { get; set; }

        public Catagory Catagory { get; set; }

        public int writerID { get; set; }

        public Writer Writer { get; set; }

        public List<Comment> Comments { get; set; }

        
        


    }
}
