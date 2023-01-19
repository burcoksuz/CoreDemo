using CoreDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoreDemo.ViewComponents
{
    public class CommentsList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var values = new List<UsersComment>
            {
                new UsersComment{ Id=1 ,Name="Cihat"},
                new UsersComment{ Id=2 ,Name="Ahmet"},
                new UsersComment{ Id=3 ,Name="Mustafa"}
            };
            return View(values);
        }
    }
}
