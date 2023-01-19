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
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
			//optionsBuilder.UseSqlServer("server=(localdb)\\mssqllocaldb;database=CoreBlogDb;integrated security=true");
			// optionsBuilder.UseSqlServer("server=DESKTOP-ECS9MI3;database=CoreBlogDb;Persist Security Info=True;User ID=sa;Password=1234");
			optionsBuilder.UseSqlServer("server=DESKTOP-C0POVI5\\SQLEXPRESS01; database=CoreBlogDb; integrated security=true;");
		}
        public DbSet<About> Abouts { get; set; }
        public DbSet<Blog>  Blogs { get; set; }
        public DbSet<Category>  Categories { get; set; }
        public DbSet<Comment>  Comments { get; set; }
        public DbSet<Contact>  Contacts { get; set; }
        public DbSet<Writer>  Writers { get; set; }
        public DbSet<NewsLetter> NewsLetters { get; set; }
        public DbSet<BlogRayting>  BlogRaytings { get; set; }
        public DbSet<Notification>  Notifications { get; set; }

    }
}
