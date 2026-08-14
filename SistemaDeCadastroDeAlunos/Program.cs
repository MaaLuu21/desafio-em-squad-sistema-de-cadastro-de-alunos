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
    }
}