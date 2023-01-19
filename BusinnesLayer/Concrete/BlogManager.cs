using BusinnesLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BusinnesLayer.Concrete
{
    public class BlogManager : IBlogService
    {
        IBlogDal _blogDal;
        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }
        
      

       

        public List<Blog> GetAllWithCategoryByWriter(int id)
        {
            return _blogDal.GetAllWithCategoryByWriter(id);
        }

        public List<Blog> GetAll(int id)
        {
            return _blogDal.GetAll(x => x.BlogID == id);
        }

        public List<Blog> GetAllWithCategory()
        {
            return _blogDal.GetAllWithCategory();
        }

        public List<Blog> GetBlogListByWriter(int id)
        {
            return _blogDal.GetAll(x=>x.WriterID==id);
        }

        public List<Blog> GetLast3Post()
        {
            return _blogDal.GetAll().Take(3).ToList();  
        }
        public Blog GetById(int id)
        {
            return _blogDal.GetById(id);
        }

        public void Add(Blog entity)
        {
            _blogDal.Add(entity);
        }

        public void Delete(Blog entity)
        {
            _blogDal.Delete(entity);
        }

        public void Update(Blog entity)
        {
            _blogDal.Update(entity);
        }

        public List<Blog> GetAll(Expression<Func<Blog, bool>> filter = null)
        {
            throw new NotImplementedException();
        }
    }
}
