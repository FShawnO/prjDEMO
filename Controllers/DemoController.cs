using Microsoft.AspNetCore.Mvc;

namespace prjDEMO.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
