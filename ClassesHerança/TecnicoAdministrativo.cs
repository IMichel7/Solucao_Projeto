namespace ClassesHerança
{
    public class TecnicoAdministrativo : Funcionario
    {
        public string Funcao { get; set; }

        public TecnicoAdministrativo(string nome = "", string cpf = "", string rg = "", Endereco? logradouro = null, string cargo = "Técnico Administrativo", string funcao = "")
            : base(nome, cpf, rg, logradouro, cargo)
        {
            Funcao = funcao;
        }
    }
}
