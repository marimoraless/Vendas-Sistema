namespace SistemaVendas.Models
{
    public class Cliente
    {
        public int ClienteID { get; set; }
        public string? NomeCliente { get; set; }

        public string? SobrenomeCliente { get; set; }

        public string? CPF { get; set; }

        public string? Email { get; set; }

        public int TelefoneCliente { get; set; }

        public int NivelAcesso { get; set; }


    }
}
