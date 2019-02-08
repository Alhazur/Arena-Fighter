using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lexicon.CSharp.InfoGenerator;

namespace Arena_Fighter
{
    class Program
    {
        public static InfoGenerator infoGen = new InfoGenerator(DateTime.Now.Millisecond);

        static void Main(string[] args)
        {
            Boy();

        }
        static void Boy()
        {
            //List<Person> people = new List<Person>();
            //people.Add(enemy);//a syda zapisat novoe nazvanie k list(enemy)

            Console.WriteLine("Your name player: ");
            string Player = Console.ReadLine();

            bool go = true;

            Person Me = new Person(Player);
                

            do
            {
                Person enemy = CreateRandomPerson();//static Person CreateRandomPerson() Klass nazvanie i novoe nazvanie dlya cheloveka!
                Battle battle = new Battle(Me, enemy);

                if (Me.health <= 0)
                {
                    go = false;
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                    battle.StartBattle();
                }
                Console.ReadKey();

            } while (go);


        }
        static Person CreateRandomPerson()
        {
            return new Person(
                infoGen.NextFullName(),//random imya, Next doljen bit
                infoGen.Next(1, 10),
                infoGen.Next(1, 10),
                infoGen.Next(1, 10));
        }
        public static void PrintList(Person Me)//vizozivaet List<Person>
        {
            Console.Clear();
            Console.WriteLine("Final Statistics\n");
            Console.WriteLine(Me);

            foreach (string item in Me.BattleHistory)//pokazivaet iz Lista
            {
                Console.WriteLine(item);
            }
        }




    }
}