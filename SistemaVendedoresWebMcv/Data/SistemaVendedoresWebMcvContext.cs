using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SistemaVendedoresWebMcv.Models;

namespace SistemaVendedoresWebMcv.Data
{
    public class SistemaVendedoresWebMcvContext : DbContext
    {
        public SistemaVendedoresWebMcvContext (DbContextOptions<SistemaVendedoresWebMcvContext> options)
            : base(options)
        {
        }

        public DbSet<Departamento> Departamento { get; set; } = default!;
        public DbSet<Vendedor> Vendedor { get; set; } = default!;
        public DbSet<RegistroVenda> RegistroVenda { get; set; } = default!;
    }
}
