using System;
using System.Globalization;

/* Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago */

namespace ex5;

class Program
{
    static void Main(string[] args)
    {
        string[] vetor1 = Console.ReadLine().Split(' ');
        int cod1 = int.Parse(vetor1[0]);
        int num1 = int.Parse(vetor1[1]);
        float preco1 = float.Parse(vetor1[2], CultureInfo.InvariantCulture);

        string[] vetor2 = Console.ReadLine().Split(' ');
        int cod2 = int.Parse(vetor2[0]);
        int num2 = int.Parse(vetor2[1]);
        float preco2 = float.Parse(vetor2[2], CultureInfo.InvariantCulture);
        
        float valor = num1 * preco1 + num2 * preco2;

        Console.WriteLine("VALOR A PAGAR: R$ " + valor.ToString("F2", CultureInfo.InvariantCulture));
    }
}