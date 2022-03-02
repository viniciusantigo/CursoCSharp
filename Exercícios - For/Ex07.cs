/* Fazer um programa para ler um número inteiro positivo N. O programa deve então mostrar na tela N linhas,
começando de 1 até N. Para cada linha, mostrar o número da linha, depois o quadrado e o cubo do valor, conforme
exemplo */

using System;

namespace Exercicios_For
{
    class Ex07
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int primeiro = i;
                int segundo = i * i;
                int terceiro = primeiro * segundo;

                Console.WriteLine($"{primeiro} {segundo} {terceiro}");

            }
        }
    }
}