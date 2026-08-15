using System;

namespace SistemaDeCadastroDeAlunos;

class Program
{
    static void Main(string[] args)
    {
        string[] nomes = new string[10];
        int[] idades = new int[10];
        decimal[] notas1 = new decimal[10];
        decimal[] notas2 = new decimal[10];
        decimal[] mediaAluno = new decimal[10];
        int alunos = 0;


        // CADASTRO - ELIS
        Console.WriteLine("Cadastro de alunos");

        for (alunos = 0; alunos < 10; alunos++)
        {
            Console.WriteLine($"Aluno {alunos + 1}");

            Console.WriteLine("Nome: ");
            nomes[alunos] = Console.ReadLine();

            Console.WriteLine("Idade: ");
            idades[alunos] = int.Parse(Console.ReadLine());

            Console.WriteLine("Nota 1: ");
            notas1[alunos] = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Nota 2: ");
            notas2[alunos] = decimal.Parse(Console.ReadLine());

            alunos++;

            if (alunos == 10)
            {
                Console.WriteLine("Limite de 10 alunos atingido.");
                break; // menu principal
            }

            Console.WriteLine("Deseja cadastrar outro aluno? (S/N): ");
            string resposta = Console.ReadLine().ToLower();

            if (resposta != "s")
            {
                break; //menu principal
            }
        }

        int opcao;
        do
        {

            //MENU - LAURA


            if (!int.TryParse(Console.ReadLine(), out opcao)) opcao = -1;
            Console.WriteLine();

            switch (opcao)
            {
                case 1:
                    // ETAPA 2 - LISTAGEM - RAFA
                    break;
                case 2:
                    // ETAPA 3 - BUSCA - DRI
                    break;

                case 3:
                    // ETAPA 4 - APROVAÇÃO - MALU
                    int quantidadeAprovada = 0;

                    for (int i = 0; i < alunos; i++)
                    {
                        mediaAluno[i] = (notas1[i] + notas2[i]) / 2;
                    }

                    Console.WriteLine("Alunos aprovados");

                    for (int i = 0; i < alunos; i++)
                    {
                        if (mediaAluno[i] >= 7)
                        {
                            Console.WriteLine("");
                            Console.WriteLine($"{nomes[i]} - Média {mediaAluno[i]:F2}");
                            quantidadeAprovada++;
                        }

                    }
                    Console.WriteLine("");
                    Console.WriteLine($"Total: {quantidadeAprovada} alunos");
                    break;

                case 4:
                    // ETAPA 5 - MEDIA TURMA - RAFA
                    break;

                case 0:
                    Console.WriteLine("Sistema encerrado.");
                    break;

                default:
                    Console.WriteLine("Operação Inválida");
                    break;
            }
        } while (opcao != 0);
    }
}