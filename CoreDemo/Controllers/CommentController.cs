using BusinnesLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using System;

namespace CoreDemo.Controllers
{
	[AllowAnonymous]
	public class CommentController : Controller
	{
		CommentManager commentManager = new CommentManager(new EfCommentDal());
		public IActionResult Index()
		{
			return View();
		}
		[HttpGet]
		public PartialViewResult PartialAddComment()
		{
			return PartialView();
		}
		[HttpPost]
		public PartialViewResult PartialAddComment(Comment p)
		{
			p.CommentDate = DateTime.Parse(DateTime.Now.ToShortTimeString());
			p.CommentStatus = true;
			p.BlogID = 2;
			commentManager.Add(p);
			return PartialView();
		}

		public PartialViewResult CommentListByBlog(int id)
		{
			var values = commentManager.GetAll(c => c.BlogID == id);
			return PartialView(values);
		}
	}
}
