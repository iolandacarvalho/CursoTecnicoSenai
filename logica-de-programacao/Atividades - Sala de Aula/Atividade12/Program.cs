using System;
					
public class Program
{
	public static void Main()
	{
		//Console.WriteLine("Hello World");
		
		
		Console.WriteLine ("------------------------------\n");
		Console.WriteLine ("  - JOGO: ACERTE O NÚMERO -");
		Console.WriteLine ("\n------------------------------");
		Console.WriteLine ("*o número está entre 1 e 100*");
		Console.WriteLine ("------------------------------");
	
		
		Random randNum = new Random();
		int n = randNum.Next(1,100);
		int palpite = 0;
		int cont = 0;
		
		while (palpite != n) {
			
			Console.Write ("\nFaça o seu palpite: ");
			string respostaS = Console.ReadLine ();
			int resposta = int.Parse (respostaS);
			palpite = resposta;
			cont = cont + 1;
			
			if (palpite < n) {
				Console.WriteLine ("Muito baixo! Tente novamente.");
			}
			
			else if (palpite > n) {
				Console.WriteLine ("Muito alto! Tente novamente.");
			}
			
			else {
				Console.WriteLine ($"\nPARABÉNS, VOCÊ ACERTOU!\nO número é {n}.");
				Console.WriteLine ($"\nNúmero de tentativas: {cont}\n");
				
			}
		}
			

	}
}