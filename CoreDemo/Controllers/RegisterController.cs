using BusinnesLayer.Concrete;
using BusinnesLayer.ValidatorRules;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
	[AllowAnonymous]
	public class RegisterController : Controller
	{
		WriterManager writerManager = new WriterManager(new EfWriterDal()); 
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Index(Writer p)
		{  WriterValidator  validator = new WriterValidator();	
			ValidationResult validationResult = validator.Validate(p);

			if (validationResult.IsValid)
			{
                p.WriterStatus = true;
                p.WriterAbout = "deneme 123";
                writerManager.Add(p);
                return RedirectToAction("Index", "Blog");
            }
			else
			{
				foreach(var item in validationResult.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
			}
			return View();
			
		}
	}
}
