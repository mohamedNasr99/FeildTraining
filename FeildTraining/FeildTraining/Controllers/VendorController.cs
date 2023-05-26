using Microsoft.AspNetCore.Mvc;

namespace Mama_Food.Controllers
{
    public class VendorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult All()
        {
            return View();
        }
    }
}
