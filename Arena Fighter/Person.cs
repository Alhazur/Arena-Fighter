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
        public int strength;
        public int damage;
        public int health;
        
         

        public Person(string Name, int strength, int damage, int health)
        {
            this.Name = Name;//esli pole i metod odinakovoe to nado pisat this
            Random r = new Random();
            this.strength = r.Next(1, 10);
            this.damage = r.Next(1, 6);
            this.health = r.Next(1, 10);
            
        }

        public Person()
        {
        }

        public void Print()
        {
            

            Console.WriteLine("Strength: " + strength);
            Console.WriteLine("Damage: " + damage);
            Console.WriteLine("Health: " + health);
        }

        public void kick()
        {
            Console.WriteLine("Name: " + Name + " Strength: " + strength + " Damage: " + damage + " Health: " + health);
        }

        public override string ToString()//eto stroka pokazyvaet v liste + public void toje doljen bit
        {
            Console.WriteLine("\nOpponent");
            return "Name: " + Name + "\nStrength: " + strength + "\nDamage: " + damage + "\nHealth: " + health;
        }
    }

}
