using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        public void Add(T entity)
        {
            using (Context context = new Context())
            {
                context.Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(T entity)
        {
            using (Context context = new Context())
            {
                context.Remove(entity);
                context.SaveChanges();
            }
        }

     

        public T GetById(int id)
        {
            using (Context context = new Context())
            {
                return context.Set<T>().Find(id);
            }
        }

        public void Update(T entity)
        {
            using (Context context = new Context())
            {
                context.Update(entity);
                context.SaveChanges();
            }
        }

        List<T> IRepositoryBase<T>.GetAll(Expression<Func<T, bool>> filter=null)
        {
            using (var context = new Context())
            {
                return filter == null
                    ? new List<T>(context.Set<T>().ToList())
                    : new List<T>(context.Set<T>().Where(filter).ToList());
            }
        }
    }
}
