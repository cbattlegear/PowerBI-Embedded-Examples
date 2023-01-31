using Microsoft.AspNetCore.Mvc;

namespace AppOwnsData.Controllers
{
    public class RLSController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
