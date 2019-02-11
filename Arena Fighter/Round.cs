using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arena_Fighter
{
    class Round
    {
        private Person enemy;//nujno sozdat otdelno dvuh chelovek na pole
        private Person me;// eto pole
        int diceEnemy;
        int diceMe;// i dat novoe nazvanie

        public Round(Person me, Person enemy)//i te dve pole nujno zapisat v public
        {

            this.enemy = enemy;//pervoe s pole a vtoroe s skobok public
            this.me = me;

            diceEnemy = Program.infoGen.Next(1, 6);//eto shkala ydachi ili slychaynih chisel idet iz main program
            diceMe = Program.infoGen.Next(1, 6);
            
            int powerMe = me.strength + diceMe;//powerMe eto = me.strength + Random
            int powerEnemy = enemy.strength + diceEnemy;
            
            Console.ReadLine();
            Console.Write("Round: " + me.Name + " " + powerMe + " (" + me.strength + "+" + diceMe + ") VS ");
            Console.WriteLine(enemy.Name + " " + powerEnemy + " (" + enemy.strength + "+" + diceEnemy + ")");

            if (powerEnemy < powerMe)
            {
                enemy.health -= me.damage;//esli ya sil net - egojizn
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(me.Name + " attacks -->> " + enemy.Name + " takes " + me.damage + " damage.");
                Console.ResetColor();
                Console.WriteLine("Remaining health: " + me.Name + " (" + me.health + "), " + enemy.Name + " (" + enemy.health + ")");

            }
            else if (powerEnemy > powerMe)
            {
                me.health -= enemy.damage;//esli on sil net - egojizn
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(enemy.Name + " attacks-->> " + me.Name + " takes " + enemy.damage + " damage.");
                Console.ResetColor();
                Console.WriteLine("Remaining health: " + me.Name + " (" + me.health + "), " + enemy.Name + " (" + enemy.health + ")\n");

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("draw\n");//eto nechya
                Console.ResetColor();
            }

        }
    }
}
