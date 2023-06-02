using Microsoft.AspNetCore.Mvc;

namespace LogWorkWebSite.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
