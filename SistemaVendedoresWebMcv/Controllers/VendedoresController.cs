using Microsoft.AspNetCore.Mvc;

namespace SistemaVendedoresWebMcv.Controllers
{
    public class VendedoresController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
