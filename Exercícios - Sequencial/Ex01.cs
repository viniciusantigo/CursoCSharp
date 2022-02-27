using System;

/*Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma
mensagem explicativa, conforme exemplos.*/

namespace Ex1
{
    class Ex01
    {
        static void Main(string[] args)
        {
            Console.Write("Primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Segundo número: ");
            int b = int.Parse(Console.ReadLine());

            int soma = a + b;

            Console.WriteLine($"SOMA = {soma}");
        }
    }
}