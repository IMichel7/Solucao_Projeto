namespace ClassesHerança
{
    public class Aluno : Pessoa
    {
        public int Matricula { get; set; }
        public Curso CursoAluno { get; set; }

        public Aluno(string nome = "", string cpf = "", string rg = "", Endereco? logradouro = null, int matricula = 0, Curso? cursoAluno = null)
            : base(nome, cpf, rg, logradouro)
        {
            Matricula = matricula;
            CursoAluno = cursoAluno ?? new Curso();
        }
    }
}
