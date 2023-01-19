using BusinnesLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreDemo.Controllers
{
    [AllowAnonymous]
    public class DashboardController : Controller
    {
        BlogManager blogManager = new BlogManager(new EfBlogDal());
        public IActionResult Index()
        {
            Context context = new Context();
            ViewBag.v1=context.Blogs.Count().ToString();
            ViewBag.v2=context.Blogs.Where(x=>x.WriterID==1). Count().ToString();
            ViewBag.v3= context.Categories.Count().ToString();
            return View();
        }
    }
}
