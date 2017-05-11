using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestCoreWebApp.DAL;

namespace TestCoreWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            ViewData["ClassName"] = "This is a SharePoint class...?";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public String HelloWorld()
        {
            return "Hello World!";
        }

        public IActionResult GetBlogPost()
        {
            Post p = new Post() { PostId = 00, Content="ABCDEF", Title="ABC" };
            return new JsonResult(p);
        }

        public IActionResult Error()
        {
            return View();
        }

    }
}
