using Microsoft.AspNetCore.Mvc;

namespace SchoolMVC.Controllers
{
    public class SchoolController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}