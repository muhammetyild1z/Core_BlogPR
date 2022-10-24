using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Core_BlogPR.Models
{
    public class AddProfieImage
    {
        public int writerID { get; set; }
        public string writerName { get; set; }
        public string writerAbout { get; set; }
        public IFormFile writerImage { get; set; }
        public string writerMail { get; set; }
        public string writerPassword { get; set; }
        public bool writerStatus { get; set; }

        
    }
}
