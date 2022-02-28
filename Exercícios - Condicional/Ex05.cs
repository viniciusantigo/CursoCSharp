/* Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A
seguir, calcule e mostre o valor da conta a pagar. 
 - CACHORRO QUENTE - 4.00
 - X-SALADA - 4.50
 - X-BACON - 5.00
 - TORRADA SIMPLES - 2.00
 - REFRIGERANTE - 1.50*/

using System;
using System.Globalization;

namespace Exercicios_Condicional;

class Ex05
{
    static void Main(string[] args)
    {
        string[] vetor = Console.ReadLine().Split(' ');
        int codigo = int.Parse(vetor[0]);
        int quantidade = int.Parse(vetor[1]);

        double valor = 0;

        if (codigo == 1)
        {
            valor = quantidade * 4.00;
        }

        else if (codigo == 2)
        {
            valor = quantidade * 4.50;
        }

        else if (codigo == 3)
        {
            valor = quantidade * 5.00;
        }

        else if (codigo == 4)
        {
            valor = quantidade * 2.00;
        }

        else if (codigo == 5)
        {
            valor = quantidade * 1.50;
        }

        Console.WriteLine("Total: R$ " + valor.ToString("F2", CultureInfo.InvariantCulture));
    }
}
