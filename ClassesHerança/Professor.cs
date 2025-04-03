namespace ClassesHerança
{
    public class Professor : Pessoa
    {
        public int Registro { get; set; }
        public string Titulacao { get; set; }
        public string Area { get; set; }

        public Professor(string nome = "", string cpf = "", string rg = "", Endereco? logradouro = null, int registro = 0, string titulacao = "", string area = "")
            : base(nome, cpf, rg, logradouro)
        {
            Registro = registro;
            Titulacao = titulacao;
            Area = area;
        }
    }
}
