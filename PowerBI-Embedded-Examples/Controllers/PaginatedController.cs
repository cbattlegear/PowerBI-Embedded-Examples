using Microsoft.AspNetCore.Mvc;

namespace AppOwnsData.Controllers
{
    public class PaginatedController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
