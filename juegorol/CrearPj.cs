using System;
using System.Collections.Generic;
using System.Text;

namespace juegorol
{
    public enum RandomNames
    {
        Arod,
        Banazir,
        Aragorn,
        Frodo,
        Bilbo,
        Gandalf,
        Samwise,
        Peregrin,
        Meriadoc,
        Beorn,
        Boromir
    }
    class CreadorPersonaje
    {
        public List<Pj> personajes = new List<Pj>();

        readonly Random Random = new Random();

        public Pj MakeRandomCharacter()
        {
            Pj newCharacter = new Pj
            {
                Health = 100,
                Level = 1,
                Name = NameGenerator(),
                Race = RaceGenerator(),
                Birthdate = BirthGenerator(),
                Mspeed = StatGenerator(1, 10),
                Hability = StatGenerator(1, 5),
                Streght = StatGenerator(1, 10),
                Armor = StatGenerator(1, 10),
            };
            newCharacter.NickName = NickGenerator();
            newCharacter.Age = AgeGenerator(newCharacter.Birthdate);
            return newCharacter;
        }

        string NameGenerator()
        {
            Array randomName = Enum.GetValues(typeof(RandomNames));
            return ((RandomNames)randomName.GetValue(Random.Next(randomName.Length))).ToString();
        }

        string NickGenerator()
        {
            string[] randomNicks = { "Escoria", "Tramposin", "Pelado", "Valar" };
            int rngNick = Random.Next(randomNicks.Length);
            return randomNicks[rngNick];
        }

        DateTime BirthGenerator()
        {
            TimeSpan years = new TimeSpan(Random.Next(0, 301) * 365, 0, 0, 0);
            return DateTime.Now - years;
        }
        
        int AgeGenerator(DateTime Birthdate)
        {
            DateTime today = DateTime.Now;
            int age = today.Year - Birthdate.Year;

            if (today.Month < Birthdate.Month || (today.Month == Birthdate.Month && today.Day < Birthdate.Day))
            {
                age--;
            }

            return age;
        }

        TipoPersonaje RaceGenerator()
        {
            Array raceSelect = Enum.GetValues(typeof(TipoPersonaje));
            return (TipoPersonaje)raceSelect.GetValue(Random.Next(raceSelect.Length));
        }

        int StatGenerator(int min, int max)
        {
            return Random.Next(min, max + 1);
        }
    }



}


      
    
