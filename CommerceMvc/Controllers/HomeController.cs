using CommerceMvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CommerceMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string currentUser)
        {
            Response.Cookies.Append(currentUser, "Logged In");
            ViewData["user"] = currentUser;
            return RedirectToAction("Index");
        }

        public IActionResult Logout(string currentUser)
        {
            string currentUserValue = Request.Cookies["currentUser"];
            if (currentUserValue != null)
            {
                //Response.Cookies.Delete(currentUser);
                Response.Cookies.Append(currentUser, "Logged Out", new CookieOptions
                {
                    Expires = DateTimeOffset.UtcNow.AddDays(-1)
                });
            }
            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}