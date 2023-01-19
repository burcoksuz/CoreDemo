using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfBlogDal : RepositoryBase<Blog>, IBlogDal
    {
        public List<Blog> GetAllWithCategory()
        {
            using (Context context = new Context())
            {
                return context.Blogs.Include(a => a.Category).ToList();
            }
        }

        public List<Blog> GetAllWithCategoryByWriter(int id)
        {
            using (Context context = new Context())
            {
                return context.Blogs.Include(a => a.Category).Where(x => x.WriterID == id).ToList();
            }
        }
    }
}
