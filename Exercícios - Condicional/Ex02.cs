/* Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar */
using System;

namespace Exercicios_Condicional;

class Ex02
{
    static void Main(string[] args)
    {
        Console.Write("Informe um número pra saber se ele é par ou ímpar: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero % 2 == 0)
        {
            Console.WriteLine("O número informado é PAR.");
        }
        else
        {
            Console.WriteLine("O número informado é ÍMPAR.");
        }
    }
}