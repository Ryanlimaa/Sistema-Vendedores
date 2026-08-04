using Microsoft.AspNetCore.Mvc;
using SistemaVendedoresWebMcv.Services;

namespace SistemaVendedoresWebMcv.Controllers
{
    public class VendedoresController : Controller
    {
        private readonly VendedorService _vendedorservice;

        public VendedoresController(VendedorService vendedorService)
        {
            _vendedorservice = vendedorService;
        }
        public IActionResult Index()
        {
            var list = _vendedorservice.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
