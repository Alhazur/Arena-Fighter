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
            Console.WriteLine("---Arena Fighter---");
            Boy();

        }
        static void Boy()
        {
            //List<Person> people = new List<Person>();
            //people.Add(enemy);//a syda zapisat novoe nazvanie k list(enemy)

            Console.WriteLine("Your name player: ");
            string Player = Console.ReadLine();            
            Person Me = new Person(Player);
            bool keepAlive = true;
            string yesNo;
            //
            do
            {
                Me.Print();
                ////
                if (Me.health > 0)//esli jizn menshe to on ne sprosit zanovo!
                {
                    Console.WriteLine("\nWhat do you want to do?\nY - Hunt for an opponent\nN - Retire from fighting");
                    yesNo = Console.ReadLine();
                }
                else
                {
                    yesNo = "no";//sam zavershit dejstvie
                }
                ////

                if (yesNo.Equals("y"))//esli najat da to nachnet igru
                {
                    Person enemy = CreateRandomPerson();//static Person CreateRandomPerson() Klass nazvanie i novoe nazvanie dlya cheloveka!
                    Battle battle = new Battle(Me, enemy);//vizov klassa 
                    battle.StartBattle();//start klassa

                }
                else
                {
                    Console.WriteLine("\nYou have ended the violence by not fighting.\n");
                    Console.ReadLine();
                    PrintList(Me);
                    Console.ReadKey();
                    keepAlive = false;
                }

            } while (keepAlive);
            //
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