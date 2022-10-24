using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        protected override void  OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-AU0NPSR\\SQLEXPRESS; database=Core_Blog_Db; integrated security=true");
        }
        public DbSet<About>Abouts { get; set; }

        public DbSet<Blog>Blogs { get; set; }

        public DbSet<Catagory>Catagoies { get; set; } 

        public DbSet<BlogReyting>blogReytings { get; set; }

        public DbSet<Comment>Comments { get; set; }

        public DbSet<Contact>Contacts { get; set; }

        public DbSet<Writer> Writers { get; set; }

        public DbSet<NewsLatter> NewsLatters { get; set; }

        public DbSet<Notification> notifications { get; set; }

        public DbSet<Message> messages { get; set; }

        public DbSet<Admin> Admins { get; set; }
        
    }
}
