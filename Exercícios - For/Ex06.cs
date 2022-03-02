/* Ler um número inteiro N e calcular todos os seus divisores. */

using System;

namespace Exercicio_For
{
    class Ex06
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; n <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}