/* Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste
de 3 valores reais, cada um deles com uma casa decimal. Apresente a média ponderada para cada um destes
conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem
peso 5. */

using System;
using System.Globalization;

namespace Exercicio_For
{
    class Ex03
    {
        static void Main(string[] args)
        {
            int usuario = int.Parse(Console.ReadLine());
            double media = 0;

            for (int i = 0; i < usuario; i++)
            {
                string[] vetor = (Console.ReadLine().Split(' '));
                double n1 = double.Parse(vetor[0], CultureInfo.InvariantCulture);
                double n2 = double.Parse(vetor[1], CultureInfo.InvariantCulture);
                double n3 = double.Parse(vetor[2], CultureInfo.InvariantCulture);

                media = (n1 * 2 + n2 * 3 + n3 * 5) / 10;

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}