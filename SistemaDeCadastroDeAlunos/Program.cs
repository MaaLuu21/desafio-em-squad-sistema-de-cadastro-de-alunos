string[] nomes = new string[10];
int[] idades = new int[10];
decimal[] notas1 = new decimal[10];
decimal[] notas2 = new decimal[10];
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
}
