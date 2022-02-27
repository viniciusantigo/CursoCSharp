using System;
using System.Globalization;
/* Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
casas decimais conforme exemplos.
Fórmula da área: area = π . raio2
Considere o valor de π = 3.14159 */


namespace Ex2
{

    class Ex02
    {
        private static void Main(string[] args)
        {
            double entrada = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double area = 3.14159 * Math.Pow(entrada,2);
            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));
        }

    }
}