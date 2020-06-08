using Microsoft.AspNetCore.Mvc;

namespace PortfolioDJ {
    public class HomeController : Controller {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("/projects")]
        public IActionResult Projects()
        {
            return View("Projects");
        }

        [HttpGet("/contacts")]
        public IActionResult Contacts()
        {
            return View("Contacts");
        }

        [HttpGet("/strresp")]
        public string Strresp()
        {
            return "It's a string responce";
        }
    }
}