namespace ClassesHerança
{
    public class Funcionario : Pessoa
    {
        public string Cargo { get; set; }

        public Funcionario(string nome = "", string cpf = "", string rg = "", Endereco? logradouro = null, string cargo = "")
            : base(nome, cpf, rg, logradouro)
        {
            Cargo = cargo;
        }
    }
}
