using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arena_Fighter
{
    class Person
    {
        public string Name { get; set; }
        public int strength { get; set; }
        public int damage { get; set; }
        public int health { get; set; }
        private static Random r = new Random();//esli nechego pisat to on budet vsegda privat



        public Person(string Name, int strength, int damage, int health)
        {
            this.Name = Name;//esli pole i metod odinakovoe to nado pisat this

            this.strength = strength;
            this.damage = damage;
            this.health = health;
            

        }

        public Person(string name)// eto ja toest me
        {
            Name = name;
            this.strength = r.Next(1, 10);
            this.damage = r.Next(1, 10);
            this.health = r.Next(1, 10);

        }

        public void Print()
        {
            Console.WriteLine("Name: "+ Name);
            Console.WriteLine("Strength: " + strength);
            Console.WriteLine("Damage: " + damage);
            Console.WriteLine("Health: " + health);
        }

        //public void kick()
        //{
           
        //    Console.WriteLine("Name: " + Name + " Strength: " + strength + " Damage: " + damage + " Health: " + health);
        //}

        public override string ToString()//eto stroka pokazyvaet v liste + public void toje doljen bit
        {
            Console.WriteLine("\nOpponent");
            return "Name: " + Name + "\nStrength: " + strength + "\nDamage: " + damage + "\nHealth: " + health;
        }
    }

}
