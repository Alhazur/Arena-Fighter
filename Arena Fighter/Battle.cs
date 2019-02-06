using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arena_Fighter
{
    class Battle
    {
        public Person Me { get; set; }//esli klass otdilno to nado zadat dlya igrokov otdelnie Property
        public Person Enemy { get; set; }

        public Battle(Person me, Person enemy)
        {
            Me = me;
            Enemy = enemy;
        }

        public void StartBattle()
        {

            Me.Print();
            Console.WriteLine("\n---VS---\n");
            Enemy.Print();

            while (Me.health > 0 && Enemy.health > 0)
            {
                Round round = new Round(Me, Enemy);
                if (Me.health < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nGame Over");
                    Console.ResetColor();
                }
                else if (Enemy.health <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nYou won!");
                    Console.ResetColor();
                }
                
            }
        }
    }
}
