using System;
using System.Collections.Generic;
using System.Text;

namespace juegorol
{
    class Program
    {
        static void Main(string[] args)
        {
            int nCharacters;
            string inputChar;
            Pj player1, player2;
            List<Pj> Players = new List<Pj>();
            CreadorPersonaje characterCreated = new CreadorPersonaje();
            Fight newFight = new Fight();

            do
            {
                Console.Write("Ingrese el número de jugadores: ");
                inputChar = Console.ReadLine();
            } while (!int.TryParse(inputChar, out nCharacters) || nCharacters <2);

            for (int i=0; i < nCharacters; i++) 
            {
                Players.Add(characterCreated.MakeRandomCharacter());
            }

            foreach(Pj pjs in Players)
            {
                pjs.MostrarPje();
            }

            do
            {
                player1 = newFight.Selection(Players);
                do
                {
                    player2 = newFight.Selection(Players);
                } while (player1 == player2);

                newFight.Combat(Players, player1, player2);
            } while (Players.Count > 1);
        }
    }
}
