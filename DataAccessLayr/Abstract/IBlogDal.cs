using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IBlogDal : IRepositoryBase<Blog>
    {
     List<Blog> GetAllWithCategory();
     List<Blog> GetAllWithCategoryByWriter(int id);
    }
}
