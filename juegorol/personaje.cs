using System;
using System.Collections.Generic;
using System.Text;

namespace juegorol
{
    public enum TipoPersonaje
    {
        Human,
        BloodElf,
        Orc,
        Forsaken,
        Dwarf
    }

    class Pj
    {
        Random Random = new Random();
        private TipoPersonaje race;
        private string name;
        private string nickName;
        private DateTime birthdate;
        private int age;
        private float health;

        private int mspeed;
        private int hability;
        private int streght;
        private int level;
        private int armor;



        public void MostrarPje()
        {
            Console.WriteLine("\n-------------------------------");
            Console.WriteLine("\nDatos del personaje:");
            Console.WriteLine($"Nombre: {Name}");
            Console.WriteLine($"Apodo: {NickName}");
            Console.WriteLine($"Fecha de nacimiento: {Birthdate}");
            Console.WriteLine($"Edad: {Age}");
            Console.WriteLine($"Tipo: {Race}");
            Console.WriteLine("\nCaracteristicas del personaje:");
            Console.WriteLine($"Nivel: {Level}");
            Console.WriteLine($"Velocidad: {Mspeed}");
            Console.WriteLine($"Destreza: {Hability}");
            Console.WriteLine($"Fuerza: {Streght}");
            Console.WriteLine($"Armadura: {Armor}");
        }

        public void Attack(Pj defensor)
        {
            float Attack = Hability * Streght * Level;
            float Precision = (float)Random.Next(1, 101);
            float ad = Attack * Precision;
            float critChance = Random.Next(1, 4);

            float poderDeDefensa = (float)(defensor.Armor * defensor.Mspeed);
            float maxDamage = 50000;

            float damage = ((ad * Precision - poderDeDefensa) / maxDamage) * critChance * 10;


            defensor.Health -= damage;
        }
        
        public TipoPersonaje Race { get => race; set => race = value; }
        public string Name { get => name; set => name = value; }
        public string NickName { get => nickName; set => nickName = value; }
        public DateTime Birthdate { get => birthdate; set => birthdate = value; }
        public int Age { get => age; set => age = value; }
        public int Mspeed { get => mspeed; set => mspeed = value; }
        public int Hability { get => hability; set => hability = value; }
        public int Streght { get => streght; set => streght = value; }
        public int Level { get => level; set => level = value; }
        public int Armor { get => armor; set => armor = value; }
        public float Health { get => health; set => health = value; }
    }
}
