/* Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode
começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas. */

using System;

namespace Exercicios;

class Ex04
{
    static void Main(string[] args)
    {
        string[] vetor = Console.ReadLine().Split(' ');

        int hora_inicial = int.Parse(vetor[0]);
        int hora_final = int.Parse(vetor[1]);

        int duracao; 
        if (hora_inicial < hora_final)
        {
            duracao = hora_final - hora_inicial;
        }
        else
        {
            duracao = 24 - hora_inicial + hora_final;
        }

        Console.WriteLine("O jogo durou " + duracao + " hora(s)");
    }
}