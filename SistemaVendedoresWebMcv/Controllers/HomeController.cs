using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SistemaVendedoresWebMcv.Models.ViewModels;

namespace SistemaVendedoresWebMcv.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["Mensagen"] = "Bem vindo ao Sistema de Vendedores!";
            ViewData["Nome"] = "Ryan Lima";
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
