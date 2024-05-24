# Calculadora de Média de Notas

## 📝 Este é um programa simples em C# para calcular a média de um conjunto de notas inseridas pelo usuário.

## Como Funciona

ℹ️ Este programa solicita ao usuário que insira o número de notas que deseja calcular a média. Em seguida, o usuário insere as notas uma por uma, e o programa calcula a média dessas notas.

## Funcionamento do Código

O programa começa solicitando ao usuário que insira o número de notas que deseja calcular a média.
Em seguida, ele entra em um loop para receber as notas inseridas pelo usuário e calcular sua soma.
Depois de receber todas as notas, o programa calcula a média dividindo a soma pelo número de notas.
Por fim, exibe a média das notas.
Execução

## 🚀 Este programa pode ser compilado e executado em qualquer ambiente de desenvolvimento C#, incluindo o Online Compiler.

## Compilando e Executando no Online Compiler

Acesse Online Compiler.
Copie o código mediaNotas.cs.
Cole-o no editor do Online Compiler.
Clique em "Run" para compilar e executar o programa.

## Instruções de Uso

Execute o programa.
Insira o número de notas que deseja calcular a média.

Insira cada nota conforme solicitado.

Após inserir todas as notas, o programa calculará e exibirá a média.

Exemplo de Uso

```less
Quantas notas você quer calcular a média?
3
Insira a nota 1:
8
Insira a nota 2:
7.5
Insira a nota 3:
6.5
A média das 3 notas é: 7
```

## Code

```csharp
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

```

Sinta-se à vontade para ajustar e personalizar conforme necessário!