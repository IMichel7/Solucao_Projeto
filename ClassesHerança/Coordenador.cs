namespace ClassesHerança
{
    public class Coordenador : Funcionario
    {
        public string Senha { get; set; }

        public Coordenador(string nome = "", string cpf = "", string rg = "", Endereco? logradouro = null, string cargo = "Coordenador", string senha = "")
            : base(nome, cpf, rg, logradouro, cargo)
        {
            Senha = senha;
        }
    }
}
