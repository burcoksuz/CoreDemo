using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinnesLayer.Abstract
{
    public interface IAboutService:IGenericService<About>
    {
        //List<About> GetAll(Expression<Func<About, bool>> filter = null);
    }
}
