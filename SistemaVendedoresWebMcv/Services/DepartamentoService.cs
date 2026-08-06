using SistemaVendedoresWebMcv.Data;
using SistemaVendedoresWebMcv.Models;

namespace SistemaVendedoresWebMcv.Services
{
    public class DepartamentoService
    {
        private readonly SistemaVendedoresWebMcvContext _context;

        public DepartamentoService(SistemaVendedoresWebMcvContext context)
        {
            _context = context;
        }

        public List<Departamento> FindAll()
        {
            return _context.Departamento.OrderBy(x => x.Nome).ToList();
        }
    }
}
