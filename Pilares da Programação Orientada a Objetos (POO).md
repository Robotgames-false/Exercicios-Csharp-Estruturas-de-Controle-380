# Pilares da Programação Orientada a Objetos (POO)

**Encapsulamento**: O código utiliza classes e métodos para encapsular a funcionalidade de calcular a média das notas. As variáveis são protegidas dentro das classes e acessadas apenas por meio de métodos específicos.

**Herança***: Embora não esteja explicitamente presente neste código, a capacidade de criar subclasses e herdar comportamentos e características de classes base é um dos pilares da POO em C#.

**Polimorfismo**: O polimorfismo permite que objetos de diferentes tipos sejam tratados de maneira uniforme. Embora não seja demonstrado explicitamente neste código, o polimorfismo é alcançado por meio de conceitos como sobrecarga de método e sobrescrita de método.

**Abstração**: O programa abstrai o conceito de calcular a média de notas, encapsulando-o em métodos e classes. Isso permite que os detalhes de implementação sejam ocultados do usuário, que só precisa interagir com uma interface simples.

## Execução

🚀 Este programa pode ser compilado e executado em qualquer ambiente de desenvolvimento C#, incluindo o Online Compiler.

Compilando e Executando no Online Compiler
Acesse Online Compiler.

Vamos destacar exemplos específicos de como cada pilar da Programação Orientada a Objetos (POO) está presente ou poderia ser implementado no código da calculadora de média de notas.

## Encapsulamento

O encapsulamento é demonstrado no código ao utilizar classes e métodos para encapsular a funcionalidade de calcular a média das notas. As variáveis são protegidas dentro das classes e acessadas apenas por meio de métodos específicos. Aqui está um exemplo de como a classe mediaNotas encapsula a funcionalidade:

```csharp
class mediaNotas
{
    // Métodos e variáveis encapsulados dentro da classe
}
```

## Herança

Embora a herança não seja explicitamente demonstrada no código fornecido, podemos imaginar um cenário em que a classe mediaNotas seja uma classe base e subclasses poderiam ser criadas para calcular médias de notas de diferentes tipos de avaliações, como provas, trabalhos, etc. Por exemplo:

```csharp
class mediaNotas
{
    // Implementação para calcular a média de notas gerais
}

class mediaProvas : mediaNotas
{
    // Implementação específica para calcular a média de notas de provas
}

class mediaTrabalhos : mediaNotas
{
    // Implementação específica para calcular a média de notas de trabalhos
}
```

## Polimorfismo

O polimorfismo permite que objetos de diferentes tipos sejam tratados de maneira uniforme. Embora não seja demonstrado explicitamente neste código, o polimorfismo poderia ser alcançado por meio de conceitos como sobrecarga de método e sobrescrita de método. Por exemplo, imagine que tenhamos uma classe base Avaliacao com um método CalcularMedia, que é sobrescrito em subclasses para fornecer implementações específicas:

```csharp

class Avaliacao
{
    public virtual double CalcularMedia()
    {
        // Implementação padrão para calcular a média
    }
}

class Prova : Avaliacao
{
    public override double CalcularMedia()
    {
        // Implementação específica para calcular a média de notas de uma prova
    }
}

class Trabalho : Avaliacao
{
    public override double CalcularMedia()
    {
        // Implementação específica para calcular a média de notas de um trabalho
    }
}
```

## Abstração

A abstração é demonstrada no código ao encapsular o conceito de calcular a média de notas em métodos e classes. Isso permite que os detalhes de implementação sejam ocultados do usuário, que só precisa interagir com uma interface simples. Por exemplo, o usuário interage apenas com o método Main da classe mediaNotas, sem precisar se preocupar com os detalhes de como a média é calculada internamente.