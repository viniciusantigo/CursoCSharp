/* Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial de N = N * (N-1) * (N-2) * (N-3) * ... * 1.
Lembrando que, por definição, fatorial de 0 é 1. */

using System;

namespace Exercicios_For
{
    class Ex05
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int fatorial = 1;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
                fatorial *= i;
            }

            Console.WriteLine(fatorial);
        }
    }
}