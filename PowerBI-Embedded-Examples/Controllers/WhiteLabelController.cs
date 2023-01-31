using Microsoft.AspNetCore.Mvc;

namespace AppOwnsData.Controllers
{
    public class WhiteLabelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
