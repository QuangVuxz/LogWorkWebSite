using Microsoft.AspNetCore.Mvc;

namespace LogWorkWebSite.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
