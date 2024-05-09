namespace SistemaVendas.Models
{
    public class Venda
    {

        public int VendaID { get; set; }
        public int ClienteID { get; set; }
        public int ProdutoID { get; set; }
        public int FuncionárioID { get; set; }
        public int Quantidade { get; set; }
        public int TotalVenda { get; set; }

    }
}
