using SistemaVendedoresWebMcv.Models.Enuns;
namespace SistemaVendedoresWebMcv.Models
{
    public class RegistroVenda
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public double Quantidade { get; set; }
        public StatusVenda Status { get; set; }
        public Vendedor Vendedor { get; set; }

        public RegistroVenda()
        {
        }

        public RegistroVenda(int id, DateTime data, double qtd, StatusVenda status, Vendedor vendedor)
        {
            Id = id;
            Data = data;
            Quantidade = qtd;
            Status = status;
            Vendedor = vendedor;
        }
    }
}
