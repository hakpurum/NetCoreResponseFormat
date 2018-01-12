using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreResponseFormat.Web.Filters;
using NetCoreResponseFormat.Web.Models;

namespace NetCoreResponseFormat.Web.Controllers
{
    public class HomeController : Controller
    {
        [FormatReponseFilter]
        public IActionResult Index()
        {
            var users = new List<UserModel>()
            {
                new UserModel() { UserId = 1,FullName="Hasan Akpürüm" },
                new UserModel() { UserId = 2,FullName="Ahmet BlaBla" },
                new UserModel() { UserId = 3,FullName="Mehmet BlaBla" },
                new UserModel() { UserId = 4,FullName="Veli BlaBla" }

            };
            return View(users);
        }
        
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
