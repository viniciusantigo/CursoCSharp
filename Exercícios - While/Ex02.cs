/* Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema
cartesiano. Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo
menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma).*/ 

using System;
using System.Globalization;

namespace Exercicio_While {
	
	class Ex02 {
		
		static void Main(string[] args);
		
		string[] vetor = Console.ReadLine().Split(' ');
		int x = int.Parse(vetor[0], CultureInfo.InvariantCulture);
		int y = int.Parse(vetor[1], CultureInfo.InvariantCulture);
		
		While (x != 0 && y != 0) {
			
			if (x > 0.0 && y > 0.0) {
				Console.WriteLine("Primeiro");
			
			}
			
			else if (x < 0.0 && y > 0.0) {
				Console.WriteLine("Segundo")
			}
			
			
			else if (x < 0.0 && y < 0.0) {
				Console.WriteLine("Terceiro")
			}
			
			else {
				Console.WriteLine("Quarto")
			}
			
			string[] vetor = Console.ReadLine().Split(' ');
			int x = int.Parse(vetor[0], CultureInfo.InvariantCulture);
			int y = int.Parse(vetor[1], CultureInfo.InvariantCulture);
		} 
	}
}