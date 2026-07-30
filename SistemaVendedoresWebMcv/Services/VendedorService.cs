using SistemaVendedoresWebMcv.Data;
using SistemaVendedoresWebMcv.Models;

namespace SistemaVendedoresWebMcv.Services
{
    public class VendedorService
    {
        private readonly SistemaVendedoresWebMcvContext _context;

        public VendedorService(SistemaVendedoresWebMcvContext context)
        {
            _context = context;
        }

        public List<Vendedor> FindAll()
        {
            return _context.Vendedor.ToList();
        }
    }
}
