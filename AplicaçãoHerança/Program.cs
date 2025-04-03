using System;
using System.Collections.Generic;
using ClassesHerança;

namespace AplicacaoHeranca
{
    // Desenvolvido por: Seu Nome Completo
    class Program
    {
        static void Main(string[] args)
        {
            // Criação de uma lista para armazenar todos os cadastros (todos herdam de Pessoa)
            List<Pessoa> pessoas = new List<Pessoa>();

            // Cadastro de uma Pessoa
            Pessoa pessoa = new Pessoa(
                "João da Silva",
                "000.111.222-33",
                "MG-12.345.678",
                new Endereco("Rua A", 123, "Bairro A", "Cidade A", "Estado A", "12345-678")
            );
            pessoas.Add(pessoa);

            // Cadastro de um Funcionário
            Funcionario funcionario = new Funcionario(
                "Maria Oliveira",
                "111.222.333-44",
                "SP-98.765.432",
                new Endereco("Rua B", 456, "Bairro B", "Cidade B", "Estado B", "23456-789"),
                "Analista"
            );
            pessoas.Add(funcionario);

            // Cadastro de três Alunos (um deles cursando Sistemas de Informação)
            Aluno aluno1 = new Aluno(
                "Carlos Pereira",
                "222.333.444-55",
                "RJ-23.456.789",
                new Endereco("Rua C", 789, "Bairro C", "Cidade C", "Estado C", "34567-890"),
                1001,
                new Curso("Sistemas de Informação", "Curso de SI", 1200)
            );
            Aluno aluno2 = new Aluno(
                "Ana Martins",
                "333.444.555-66",
                "MG-34.567.890",
                new Endereco("Rua D", 101, "Bairro D", "Cidade D", "Estado D", "45678-901"),
                1002,
                new Curso("Engenharia", "Curso de Engenharia", 1300)
            );
            Aluno aluno3 = new Aluno(
                "Bruno Souza",
                "444.555.666-77",
                "RS-45.678.901",
                new Endereco("Rua E", 202, "Bairro E", "Cidade E", "Estado E", "56789-012"),
                1003,
                new Curso("Sistemas de Informação", "Curso de SI", 1200)
            );
            pessoas.Add(aluno1);
            pessoas.Add(aluno2);
            pessoas.Add(aluno3);

            // Cadastro de dois Professores atuando na área de Tecnologia com titulação Mestre
            Professor professor1 = new Professor(
                "Dr. Alberto",
                "555.666.777-88",
                "SP-56.789.012",
                new Endereco("Rua F", 303, "Bairro F", "Cidade F", "Estado F", "67890-123"),
                2001,
                "Mestre",
                "Tecnologia"
            );
            Professor professor2 = new Professor(
                "Dra. Beatriz",
                "666.777.888-99",
                "RJ-67.890.123",
                new Endereco("Rua G", 404, "Bairro G", "Cidade G", "Estado G", "78901-234"),
                2002,
                "Mestre",
                "Tecnologia"
            );
            pessoas.Add(professor1);
            pessoas.Add(professor2);

            // Cadastro de um Coordenador com senha "AbcBolinhas"
            Coordenador coordenador = new Coordenador(
                "Renata Lima",
                "777.888.999-00",
                "MG-78.901.234",
                new Endereco("Rua H", 505, "Bairro H", "Cidade H", "Estado H", "89012-345"),
                "Coordenador",
                "AbcBolinhas"
            );
            pessoas.Add(coordenador);

            // Cadastro de dois Técnicos Administrativos na função de "Desenvolvedor"
            TecnicoAdministrativo tecnico1 = new TecnicoAdministrativo(
                "Roberto Costa",
                "888.999.000-11",
                "RS-89.012.345",
                new Endereco("Rua I", 606, "Bairro I", "Cidade I", "Estado I", "90123-456"),
                "Técnico Administrativo",
                "Desenvolvedor"
            );
            TecnicoAdministrativo tecnico2 = new TecnicoAdministrativo(
                "Luciana Rocha",
                "999.000.111-22",
                "SP-90.123.456",
                new Endereco("Rua J", 707, "Bairro J", "Cidade J", "Estado J", "01234-567"),
                "Técnico Administrativo",
                "Desenvolvedor"
            );
            pessoas.Add(tecnico1);
            pessoas.Add(tecnico2);

            // Listagem dos cadastros
            foreach (var item in pessoas)
            {
                Console.WriteLine($"Tipo: {item.GetType().Name}");
                Console.WriteLine($"Nome: {item.Nome}");
                Console.WriteLine($"CPF: {item.Cpf}");
                Console.WriteLine($"RG: {item.Rg}");
                Console.WriteLine($"Endereço: {item.Logradouro.Rua}, {item.Logradouro.Numero}, {item.Logradouro.Bairro}, {item.Logradouro.Cidade}, {item.Logradouro.Estado}, {item.Logradouro.Cep}");

                if (item is Aluno aluno)
                {
                    Console.WriteLine($"Matrícula: {aluno.Matricula}");
                    Console.WriteLine($"Curso: {aluno.CursoAluno.Nome}");
                }
                else if (item is Professor professor)
                {
                    Console.WriteLine($"Registro: {professor.Registro}");
                    Console.WriteLine($"Titulação: {professor.Titulacao}");
                    Console.WriteLine($"Área: {professor.Area}");
                }
                else if (item is Funcionario funcionarioItem && !(item is Coordenador) && !(item is TecnicoAdministrativo))
                {
                    Console.WriteLine($"Cargo: {funcionarioItem.Cargo}");
                }
                else if (item is Coordenador coord)
                {
                    Console.WriteLine($"Cargo: {coord.Cargo}");
                    Console.WriteLine($"Senha: {coord.Senha}");
                }
                else if (item is TecnicoAdministrativo tecnico)
                {
                    Console.WriteLine($"Cargo: {tecnico.Cargo}");
                    Console.WriteLine($"Função: {tecnico.Funcao}");
                }

                Console.WriteLine("---------------------------------------------------");
            }
        }
    }
}
