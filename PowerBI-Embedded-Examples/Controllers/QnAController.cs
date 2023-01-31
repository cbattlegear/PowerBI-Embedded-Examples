using Microsoft.AspNetCore.Mvc;

namespace AppOwnsData.Controllers
{
    public class QnAController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
