/* Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e
mostre:
a) a área do triângulo retângulo que tem A por base e C por altura.
b) a área do círculo de raio C. (pi = 3.14159)
c) a área do trapézio que tem A e B por bases e C por altura.
d) a área do quadrado que tem lado B.
e) a área do retângulo que tem lados A e B. */

using System;
using System.Globalization;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vetor = Console.ReadLine().Split(' ');
            double a = double.Parse(vetor[0], CultureInfo.InvariantCulture);
            double b = double.Parse(vetor[1], CultureInfo.InvariantCulture);
            double c = double.Parse(vetor[2], CultureInfo.InvariantCulture);

            double area_triangulo = a * c / 2;
            double area_circulo = 3.14159 * Math.Pow(c, 2);
            double area_trapezio = ((a + b) * c) / 2;
            double area_quadrado = b * b;
            double area_retangulo = a * b;

            Console.WriteLine("TRIANGULO: " + area_triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + area_circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + area_trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + area_quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + area_retangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}