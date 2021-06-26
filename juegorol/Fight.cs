	using System;
	using System.Collections.Generic;
	using System.Text;

	namespace juegorol
	{
		class Fight
		{
			readonly Random Random = new Random();

			public void Combat(List<Pj> characters, Pj player1, Pj player2)
			{
				int nAttacks = 0;

				Console.WriteLine("\n--------------------------------------------");
				Console.WriteLine($"\n{player1.Name} vs {player2.Name}");

				while (nAttacks < 20 && player1.Health > 0 && player2.Health > 0)
				{
					int Rounds = nAttacks;
					player1.Attack(player2);
					Console.WriteLine("\nTurno " + Rounds);

					Console.WriteLine($"\nSalud {player2.Name}: {Math.Round(player2.Health,2)}");

					if (player2.Health > 0)
					{
						player2.Attack(player1);
						Console.WriteLine($"\nSalud {player1.Name}: {Math.Round(player1.Health, 2)}");
					}

					nAttacks++;
				}

				Console.WriteLine("\n//////////////////////////////////////");

				if(player1.Health > player2.Health)
				{
					Console.WriteLine("\nEL GANADOR ES :");
					player1.MostrarPje();
					characters.Remove(player2);
				}
				else
				{
					Console.WriteLine("\nEL GANADOR ES :");
					player2.MostrarPje();
					characters.Remove(player1);
				}

			}

			public Pj Selection(List<Pj> characters)
			{
				return characters[Random.Next(0, characters.Count)];
			}
		}
	}
