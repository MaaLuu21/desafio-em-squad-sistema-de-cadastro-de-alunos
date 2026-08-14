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
        int alunos = 0;

        // CADASTRO - ELIS
        Console.WriteLine("Cadastro de alunos");

        for (alunos = 0; alunos < 10; alunos++)
        {


            Console.WriteLine("Idade: ");
            while (!int.TryParse(Console.ReadLine(), out idades[alunos]) || idades[alunos] <= 0) // Pergunta ate o usuario dar uma idade valida
            {
                Console.Write("Idade inválida. Digite novamente: ");
            }

            // alunos++; está incrementando duas vezes

            if (alunos == 9)
            {
                Console.WriteLine("Limite de 10 alunos atingido.");
                return; // menu principal
            }
            else
            {
                Console.WriteLine("Deseja cadastrar outro aluno? (S/N): ");

                string resposta = Console.ReadLine().ToLower();

                if (resposta != "s")
                {
                    alunos++; //Quando o break é executado, o incremento normal do for não acontece:
                    break; //menu principal
                }
            }
        }

        int opcao;
        do
        {
            if (!int.TryParse(Console.ReadLine(), out opcao)) opcao = -1;
            Console.WriteLine();

            //MENU - LAURA

            switch (opcao)
            {
                case 1: // ETAPA 2 - LISTAGEM - RAFA
                    for (int i = 0; i < alunos; i++)
                    {
                        decimal media = (notas1[i] + notas2[i]) / 2;
                        Console.WriteLine($"Nome: {nomes[i]} " +
                                          $"Idade: {idades[i]} " +
                                          $"Média: {media:F1}");
                    }
                    break;
                case 2:
                    // ETAPA 3 - BUSCA - DRI
                    break;

                case 3:
                    // ETAPA 4 - APROVAÇÃO - MALU
                    break;

                case 4: // ETAPA 5 - MEDIA TURMA - RAFA
                    decimal soma = 0;
                    for (int i = 0; i < alunos; i++)
                        soma += (notas1[i] + notas2[i]) / 2;
                    decimal mediaTurma = soma / alunos;
                    Console.WriteLine($"Média da turma: {mediaTurma}");
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