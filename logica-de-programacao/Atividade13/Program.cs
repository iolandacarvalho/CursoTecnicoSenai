// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
Console.Clear();
Random randNum = new Random();
int nums = randNum.Next(1, 60);

Console.WriteLine("--------------------------------");
Console.WriteLine("          - MEGA SENA -");
Console.WriteLine("--------------------------------");

bool repetir = true;

do
{
	Console.Write("\nInforme a quantidade de jogos que você irá fazer: ");
	string jS = Console.ReadLine();
	int jogos = int.Parse(jS);

	Console.Write("Agora informe a quantidade de dezenas: ");
	string dS = Console.ReadLine();
	int dezenas = int.Parse(dS);
	Console.Write("\n");

	Console.Clear();


	if (dezenas >= 6 && dezenas <= 15)
	{
		Console.WriteLine("--------------------------------");
		for (int j = 1; j <= jogos; j++)
		{
			Console.Write($"{nums}");

			for (int cont = 1; cont <= (dezenas - 1); cont++)
			{
				nums = randNum.Next(1, 60);
				Console.Write($" - {nums}");
			}
			Console.Write("\n");
			repetir = false;
		}

		Console.WriteLine("--------------------------------\n");
		Console.Write("Informe o valor do prêmio: ");
		string pS = Console.ReadLine();
		decimal premio = decimal.Parse(pS);

		decimal premioS = premio * 0.75m;
		decimal premioC = premio * 0.15m;
		decimal premioQ = premio * 0.10m;

		Console.WriteLine($"\nQuem acertar 6 dezenas ganhará: R${Math.Round(premioS,2)}");
		Console.WriteLine($"Quem acertar 5 dezenas ganhará: R${Math.Round(premioC,2)}");
		Console.WriteLine($"Quem acertar 4 dezenas ganhará: R${Math.Round(premioQ,2)}");

	}
	else
	{
	    Console.WriteLine("------------------------------------------------------------------");
		Console.WriteLine("O número de dezenas não pode ser inferior a 6 e nem superior a 15.");
		Console.WriteLine("------------------------------------------------------------------");
		Console.WriteLine("\nTente novamente:");
	}
}

while (repetir == true);
Console.Write("\n");