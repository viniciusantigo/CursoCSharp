/* Fazer um programa para ler um número N. Depois leia N pares de números e mostre a divisão do primeiro pelo
segundo. Se o denominador for igual a zero, mostrar a mensagem "divisao impossivel". */

using System;
using System.Globalization;


namespace Exercicios_For
{
    class Ex04
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] vetor = Console.ReadLine().Split(' ');
                int x = int.Parse(vetor[0]);
                int y = int.Parse(vetor[1]);

                if (y == 0)
                {
                    Console.WriteLine("Divisão impossível.");
                }

                else
                {
                    double divisao = (double)x / y;
                    Console.WriteLine(divisao.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}