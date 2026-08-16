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
        decimal[] medias = new decimal[10];

        int quantidadeAlunos = 0;

        Console.WriteLine("Bem-vindo. Vamos Cadastrar até 10 Alunos!");

        bool validador = false;
        do
        {
            Console.WriteLine("Quantos alunos vamos cadastrar?");
            if (!int.TryParse(Console.ReadLine(), out int alunosDigitado) || alunosDigitado < 1 || alunosDigitado > 10)
            {
                Console.WriteLine("Quantidade de alunos inválida.");
            }
            else
            {
                quantidadeAlunos = alunosDigitado;
                validador = true;
            }
        } while (!validador);

        for (int i = 0; i < quantidadeAlunos; i++)
        {
            Console.WriteLine($"Digite o nome do aluno {i + 1}:");
            nomes[i] = Console.ReadLine().ToUpper().Trim();
            Console.WriteLine($"Digite a idade do aluno {i + 1}:");
            if (!int.TryParse(Console.ReadLine(), out int idadeDigitada))
            {
                Console.WriteLine("Idade Inválida, digite um número inteiro");
            }
            idades[i] = idadeDigitada;

            Console.WriteLine($"Digite a primeira nota do aluno {i + 1}:");
            if (!decimal.TryParse(Console.ReadLine(), out decimal nota1Digitada))
            {
                Console.WriteLine("Nota inválida, digite um número válido.");
            }
            notas1[i] = nota1Digitada;

            Console.WriteLine($"Digite a segunda nota do aluno {i + 1}:");
            if (!decimal.TryParse(Console.ReadLine(), out decimal nota2Digitada))
            {
                Console.WriteLine("Nota inválida, digite um número válido");
            }
            notas2[i] = nota2Digitada;

            medias[i] = (notas1[i] + notas2[i]) / 2m;
        }

        int opcao;

        do
        {
            Console.WriteLine("Menu Principal. Escolha uma opção:");
            Console.WriteLine("1 - Listar alunos");
            Console.WriteLine("2 - Buscar aluno");
            Console.WriteLine("3 - Exibir aprovados");
            Console.WriteLine("4 - Exibir média da turma");
            Console.WriteLine("0 - Encerrar");

            Console.WriteLine("Opção: ");
            if (!int.TryParse(Console.ReadLine(), out opcao))
            {
                Console.WriteLine("Opção inválida!");
                continue;
            }
            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Listando alunos...");
                    for (int i = 0; i < quantidadeAlunos; i++)
                    {
                        Console.WriteLine($"ALUNO {i + 1}");
                        Console.WriteLine($"Nome: {nomes[i]}");
                        Console.WriteLine($"Idade: {idades[i]} anos");
                        Console.WriteLine($"Média: {medias[i]}");
                        Console.WriteLine();
                    }
                    break;
                case 2:
                    Console.WriteLine("\n--- Buscar Aluno ---");
                    Console.WriteLine("Digite o nome do aluno que deseja buscar: ");

                    string nomeBusca = Console.ReadLine().ToUpper().Trim();

                    bool encontrado = false;

                    for (int i = 0; i < quantidadeAlunos; i++)
                    {
                        if (nomes[i] == nomeBusca)
                        {


                            Console.WriteLine("\nAluno encontrado!");
                            Console.WriteLine($"Nome: {nomes[i]}");
                            Console.WriteLine($"Idade: {idades[i]}");
                            Console.WriteLine($"Nota 1: {notas1[i]}");
                            Console.WriteLine($"Nota 2: {notas2[i]}");
                            Console.WriteLine($"Média: {medias[i]:F1}");

                            encontrado = true;
                            break; // Interrompe a busca assim que encontra o aluno
                        }
                    }

                    if (!encontrado)
                    {
                        Console.WriteLine("\nAluno não encontrado.");
                    }
            
            break;

                case 3:
                Console.WriteLine("Exibindo alunos aprovados...");
                break;
            case 4:
                Console.WriteLine("Exibindo média da turma...");
                decimal somaDasMedias = 0;
                for (int i = 0; i < quantidadeAlunos; i++)
                    somaDasMedias += medias[i];
                decimal mediaTurma = somaDasMedias / quantidadeAlunos;
                Console.WriteLine($"Média da turma: {mediaTurma:F2}");
                break;
            case 0:
                Console.WriteLine("Encerrando o programa...");
                break;
            default:
                Console.WriteLine("Opção inválida!");
                break;

            }


        } while (opcao != 0);


    }
}
