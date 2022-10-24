using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_BlogPR.Models
{
    public class AddBlogImage
    {
        public int blogID { get; set; }

        public string blogTitle { get; set; }

        public string blogContent { get; set; }

        public DateTime blogCreateDate { get; set; }

        public bool blogStatus { get; set; }

        public IFormFile blogThumbnailImage { get; set; }

        public IFormFile blogSmallImage { get; set; }

        public int catagoryID { get; set; }

        

        public int writerID { get; set; }
    }
}
