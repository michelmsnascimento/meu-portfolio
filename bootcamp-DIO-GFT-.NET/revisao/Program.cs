// See https://aka.ms/new-console-template for more information
using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Aluno[] alunos = new Aluno[5]
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "x")
            {
                switch(opcaoUsuario)
                {
                    case "1":
                        console.WriteLine("Informe o nome do aluno");
                        var Aluno aluno = new Aluno();
                        aluno.Nome = console.ReadLine();

                        Console.WriteLine("Informe a nota do Aluno:")

                        if (decimal.Parse(Console.ReadLine(), out decimal nota))
                        {
                            aluno.Nota = nota;
                        }
                        else
                        {
                            throw new ArgumentOutOfRangeException("Valor da nota deve ser decimal");
                        }
                        
                        alunos[indiceAluno] = aluno;
                        indiceAluno++;
                        
                        break;
                    case "2":
                    
                        break;
                    case "3":

                        break
                    default:
                        throw new ArgumentOutOfRangeException();
                        
                }

                opcaoUsuario = ObterOpcaoUsuario();
            }
        }

        private static string ObterOpcaooUsuario()
        {
            console.WriteLine("Informe a opcao desejada");
            console.WriteLine("1 - inserir o nome do aluno");
            console.WriteLine("2 - Listar de Alunos");
            console.WriteLine("3 - Calcular média geral");
            console.WriteLine("X - Sair");
            console.WriteLine();

            string opcaoUsuario = Console.Read_Line();

            return opcaoUsuario;
        }
    }
}


