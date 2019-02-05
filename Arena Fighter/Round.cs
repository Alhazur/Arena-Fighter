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

            diceEnemy = Program.infoGen.Next(1, 6);
            diceMe = Program.infoGen.Next(1, 6);

            int powerMe = me.strength + diceMe;//powerMe eto = me.strength + Random
            int powerEnemy = enemy.strength + diceEnemy;

            if (powerEnemy < powerMe)
            {
                Console.WriteLine("Your attack to enemy: " + enemy.health);
                enemy.health -= me.damage;//esli ya silnet - egojizn

            }
            else if (powerEnemy > powerMe)
            {
                Console.WriteLine("Enemies attack to you: " + me.health);
                me.health -= enemy.damage;//esli on silnet - egojizn

            }
            else
            {
                Console.WriteLine("draw");//eto nechya


            }




        }


    }
}
