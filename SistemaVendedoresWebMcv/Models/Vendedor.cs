using Microsoft.EntityFrameworkCore.Storage.Json;

namespace SistemaVendedoresWebMcv.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public double SalarioBase { get; set; }
        public Departamento Departamento { get; set; }
        public int DepartamentoId { get; set; }
        public ICollection<RegistroVenda> Venda { get; set; } = new List<RegistroVenda>();

        public Vendedor()
        {
        }

        public Vendedor(int id, string nome, string email, DateTime dataNascimento, double salarioBase, Departamento departamento)
        {
            Id = id;
            Nome = nome;
            Email = email;
            DataNascimento = dataNascimento;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }

        public void AddRegistroVenda(RegistroVenda rv)
        {
            Venda.Add(rv);
        }

        public void RemoveRegistroVenda(RegistroVenda rv)
        {
            Venda.Remove(rv);
        }

        public double TotalVendas(DateTime inicio, DateTime final)
        {
            return Venda.Where(rv => rv.Data >= inicio && rv.Data <= final).Sum(rv => rv.Quantidade);
        }
    }
}
