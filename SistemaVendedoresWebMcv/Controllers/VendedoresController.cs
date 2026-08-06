using Microsoft.AspNetCore.Mvc;
using SistemaVendedoresWebMcv.Models;
using SistemaVendedoresWebMcv.Models.ViewModels;
using SistemaVendedoresWebMcv.Services;

namespace SistemaVendedoresWebMcv.Controllers
{
    public class VendedoresController : Controller
    {
        private readonly VendedorService _vendedorservice;
        private readonly DepartamentoService _departamentoService;

        public VendedoresController(VendedorService vendedorService, DepartamentoService departamentoService)
        {
            _vendedorservice = vendedorService;
            _departamentoService = departamentoService;
        }
        public IActionResult Index()
        {
            var list = _vendedorservice.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            var departamentos = _departamentoService.FindAll();
            var viewModel = new VendedorFormViewModel { Departamentos = departamentos};
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Vendedor vendedor)
        {
            _vendedorservice.Insert(vendedor);
            return RedirectToAction(nameof(Index));
        }
    }
}
