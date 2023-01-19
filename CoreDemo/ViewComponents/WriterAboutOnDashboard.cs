using BusinnesLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents
{

    public class WriterAboutOnDashboard:ViewComponent
    {
        WriterManager writerManager = new WriterManager(new EfWriterDal());

        public IViewComponentResult Invoke()
        {

            var values = writerManager.GetWriterById(1);
            return View(values);  
        }
    }
}
