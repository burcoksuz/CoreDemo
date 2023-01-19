using BusinnesLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinnesLayer.Concrete
{
    public class CategoryManager:ICategoryService
    {
		ICategoryDal _categoryDal;
		public CategoryManager(ICategoryDal categoryDal)
		{
			_categoryDal = categoryDal;
		}

		public void Add(Category entity)
		{
			_categoryDal.Add(entity);
		}

		public void Delete(Category entity)
		{
			_categoryDal.Delete(entity);
		}

		public List<Category> GetAll(Expression<Func<Category, bool>> filter = null)
		{
			return filter == null ? _categoryDal.GetAll() : _categoryDal.GetAll(filter);

		}

		public Category GetById(int id)
		{
			return _categoryDal.GetById(id);
		}

		public void Update(Category entity)
		{
			_categoryDal.Update(entity);
		}
	}
}

