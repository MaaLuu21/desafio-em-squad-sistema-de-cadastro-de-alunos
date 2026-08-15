using System;

namespace SistemaDeCadastroDeAlunos;

class Program
{
    static void Main(string[] args)
    {
        int total = 10;
        string[] nomes = new string[total];
        int[] idades = new int[total];
        decimal[] notas1 = new decimal[total];
        decimal[] notas2 = new decimal[total];
        int alunos = 0;

        // CADASTRO - ELIS
        Console.WriteLine("\n==== CADASTRO DE ALUNOS ====");

        for (alunos = 0; alunos < total; alunos++)
        {
            Console.Write($"Nome do aluno {alunos + 1}: ");
            nomes[alunos] = (Console.ReadLine() ?? "").Trim().ToUpper();
            while (nomes[alunos] == "")
            {
                Console.Write("Nome obrigatório. Digite novamente: ");
                nomes[alunos] = (Console.ReadLine() ?? "").Trim().ToUpper();
            }
            
            Console.Write($"Idade (em anos) do aluno {alunos + 1}: ");
            while (!int.TryParse(Console.ReadLine(), out idades[alunos]) || idades[alunos] <= 0) // Pergunta ate o usuario dar uma idade valida
                Console.Write("Idade inválida. Digite novamente: ");

            Console.Write($"Nota 1 do aluno {alunos + 1} (de 0 a 10): ");
            while (!decimal.TryParse(Console.ReadLine(), out notas1[alunos]) || notas1[alunos] < 0 || notas1[alunos] > 10)
                Console.Write("Nota inválida. Digite novamente: ");

            Console.Write($"Nota 2 do aluno {alunos + 1} (de 0 a 10): ");
            while (!decimal.TryParse(Console.ReadLine(), out notas2[alunos]) || notas2[alunos] < 0 || notas2[alunos] > 10)
                Console.Write("Nota inválida. Digite novamente: ");

            // alunos++; está incrementando duas vezes

            Console.WriteLine("Deseja cadastrar outro aluno? (S/N): ");
            string resposta = Console.ReadLine().Trim().ToUpper();

            if (resposta != "S")
            {
                alunos++; //Quando o break é executado, o incremento normal do for não acontece:
                break; //menu principal
            }

            if (alunos == total - 1)
            {
                Console.WriteLine($"Limite de {total} alunos atingido.");
                alunos++;
                break; // menu principal
            }
        }

        int opcao;
        do
        {

            Console.WriteLine("\n===== SISTEMA DE ALUNOS =====");
            Console.WriteLine("1 - Listar alunos");
            Console.WriteLine("2 - Buscar aluno");
            Console.WriteLine("3 - Exibir aprovados");
            Console.WriteLine("4 - Exibir média da turma");
            Console.WriteLine("0 - Encerrar");
            Console.Write("Opção escolhida: ");

            if (!int.TryParse(Console.ReadLine(), out opcao)) opcao = -1;

            switch (opcao)
            {
                case 1: // ETAPA 2 - LISTAGEM - RAFA
                    for (int i = 0; i < alunos; i++)
                    {
                        decimal media = (notas1[i] + notas2[i]) / 2;
                        Console.WriteLine($"ALUNO {i + 1}");
                        Console.WriteLine($"Nome: {nomes[i]}");
                        Console.WriteLine($"Idade: {idades[i]} anos");
                        Console.WriteLine($"Média: {media}");
                        Console.WriteLine();
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