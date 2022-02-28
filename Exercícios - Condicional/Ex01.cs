/* Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não. */
using System;

namespace Exercicios_Condicional;

class Ex01
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero < 0)
        {
            Console.WriteLine("O número informado é negativo.");
        }
        else
        {
            Console.WriteLine("O número informado é positivo.");
        }
    }
}
