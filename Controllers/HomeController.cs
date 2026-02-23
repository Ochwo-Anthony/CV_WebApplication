using System.Diagnostics;
using AnthonyCVApplication.Models;
using Microsoft.AspNetCore.Mvc;


namespace AnthonyCVApplication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new CVModel
            {
                FullName = "Anthony Mark Ochwo",
                Title = "Final Year IT Student - Aspiring Software Developer",
                Objective = "I am an aspiring software developer with a foundation in mobile and web development. Passionate about problem-solving and developing innovative applications. Experience in Java, C#, JavaScript, and HTML."
            };

            return View(model);
        }

    }
}
