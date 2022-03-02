/* Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando
essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).*/
using System;

namespace Exercicio_For
{
    class Ex02
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int x = 0;
            int fora = 0;
            int dentro = 0;

            for(int i = 1; i <= n; i++)
            {
                x = int.Parse(Console.ReadLine());

                if (x >= 10 && x <= 20)
                {
                    dentro++;
                }

                else
                {
                    fora++;
                }
            }

            Console.WriteLine($"{dentro} in");
            Console.WriteLine($"{fora} out");
        }
    }
}