using System;

class mediaNotas
{
    static void Main()
    {
        // Solicita ao usuário que insira o número de notas
        Console.WriteLine("Quantas notas você quer calcular a media?");
        int quantidadeNotas = int.Parse(Console.ReadLine());

        // Inicializa a variável para armazenar a soma das notas
        double somaNotas = 0;

        // Loop para inserir as notas e calcular a soma
        for (int i = 1; i <= quantidadeNotas; i++)
        {
            Console.WriteLine($"Insira a nota {i}:");
            double nota = double.Parse(Console.ReadLine());
            somaNotas += nota;
        }

        // Calcula a média das notas
        double media = somaNotas / quantidadeNotas;

        // Exibe a média das notas
        Console.WriteLine($"A media das {quantidadeNotas} notas is: {media}");
    }
}
