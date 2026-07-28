using Microsoft.AspNetCore.Mvc;
using SistemaVendedoresWebMcv.Models;

namespace SistemaVendedoresWebMcv.Controllers
{
    public class DepartamentosController : Controller
    {
        public IActionResult Index()
        {
            List<Departamento> list = new List<Departamento>();
            list.Add(new Departamento { Id = 1, Nome = "Eletronicos" });
            list.Add(new Departamento { Id = 2, Nome = "Vendas" });

            return View(list);
        }
    }
}
