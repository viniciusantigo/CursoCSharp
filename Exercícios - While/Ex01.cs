/* Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha
incorreta informada, escrever a mensagem "Senha Invalida". Quando a senha for informada corretamente deve ser
impressa a mensagem "Acesso Permitido" e o algoritmo encerrado. Considere que a senha correta é o valor 2002. */
using System;

namespace Exercicios_While
{

	class ex01
	{

		static void Main(string[] args)
		{


			int senha = 2002;
			int usuario = int.Parse(Console.ReadLine());

			while (usuario != senha)
			{
				Console.WriteLine("Senha inválida!");
				usuario = int.Parse(Console.ReadLine());
			}

			Console.WriteLine("Acesso permitido!");

		}
	}

}
