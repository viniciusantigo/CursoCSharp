using System;
using System.Globalization;

/*Fazer um programa para executar a seguinte interação com o 
usuário, lendo os valores destacados em vermelho, e depois 
mostrar os dados na tela:
Entre com seu nome completo:
Alex Green
Quantos quartos tem na sua casa?
3
Entre com o preço de um produto:
500.50
Entre seu último nome, idade e altura (mesma linha):
Green 21 1.73 */

namespace Exercicios;

class ExFixação
{
    static void Main(string[] args)
    {
        Console.WriteLine("Entre com seu nome completo: ");
        string nome = Console.ReadLine();
        Console.WriteLine("Quantos quartos tem na sua casa? ");
        int quartos = int.Parse(Console.ReadLine());
        Console.WriteLine("Entre com o preço de um produto: ");
        float produto = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


        Console.WriteLine("Entre seu último nome, idade e altura (mesma linha): ");
        string[] vetor = Console.ReadLine().Split(' ');
        string sobrenome = vetor[0];
        int idade = int.Parse(vetor[1]);
        float altura = float.Parse(vetor[2], CultureInfo.InvariantCulture);

        Console.WriteLine(nome);
        Console.WriteLine(quartos);
        Console.WriteLine(produto.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine(sobrenome);
        Console.WriteLine(idade);
        Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
    }
}
