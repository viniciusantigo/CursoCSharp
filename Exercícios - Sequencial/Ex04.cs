using System;
using System.Globalization;
/* Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por
hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas
decimais.*/ 

namespace Ex4;

class Program
{
    static void Main(string[] args)
    {
        int numero = int.Parse(Console.ReadLine());
        int horas = int.Parse(Console.ReadLine());
        float valor_hora = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        float salario = horas * valor_hora;

        Console.WriteLine("NUMBER = " + numero);
        Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
    }
}