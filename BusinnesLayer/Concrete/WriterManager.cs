using BusinnesLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinnesLayer.Concrete
{
	public class WriterManager : IWriterService
	{
		IWriterDal _writerDal;
		public WriterManager(IWriterDal writerDal)
		{
			_writerDal=writerDal;	
		}
		public void Add(Writer entity)
		{
			_writerDal.Add(entity);
		}

        public void Delete(Writer entity)
        {
            throw new NotImplementedException();
        }

        public List<Writer> GetAll(Expression<Func<Writer, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Writer GetById(int id)
        {
          return  _writerDal.GetById(id); 
        }

        public List<Writer> GetWriterById(int id)
        {
          return _writerDal.GetAll(x=>x.WriterID== id); 
        }

        public void Update(Writer entity)
        {
            _writerDal.Update(entity);   
        }
    }
}
