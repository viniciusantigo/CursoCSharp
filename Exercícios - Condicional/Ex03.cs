/* Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao
Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em
ordem crescente ou decrescente. */

using System;

namespace Exercicios_Condicional;

class Ex03
{
    static void Main(string[] args)
    {
        Console.Write("Informe dois números pra saber se são múltiplos: ");
        string[] vetor = Console.ReadLine().Split(' ');
        int a = int.Parse(vetor[0]);
        int b = int.Parse(vetor[1]);

        if (a % b == 0 || b % a == 0)
        {
            Console.WriteLine("São múltiplos");
        }
        else
        {
            Console.WriteLine("Não são múltiplos");
        }
    }
}
