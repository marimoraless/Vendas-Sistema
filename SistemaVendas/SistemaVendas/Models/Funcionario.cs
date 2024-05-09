namespace SistemaVendas.Models
{
    public class Funcionario
    {

        public int FuncionarioID { get; set; }
        public string? NomeFuncionario { get; set; }
        public string? SobrenomeFuncionario { get; set; }
        public string? CPF { get; set; }

        public string? Email { get; set; }

        //public string? Senha { get; set; }

        public int NivelAcesso { get; set; }

    }
}
