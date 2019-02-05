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

            Console.WriteLine("Your name player: ");


            List<Person> people = new List<Person>();
            people.ForEach(x => x.kick());            

            bool stay = true;
            int RemainingHealth;
            int Remaining;




            string Player = Console.ReadLine();
            Person me = new Person(Player);
            me.Print();


            Person enemy = CreateRandomPerson();//static Person CreateRandomPerson() Klass nazvanie i novoe nazvanie dlya cheloveka!
            people.Add(enemy);//a syda zapisat novoe nazvanie k list(enemy)
                              //PrintList(people);
                              //Console.WriteLine();
            Console.Clear();
            Battle battle = new Battle(me, enemy);
            battle.StartBattle();




            Console.ReadKey();
        }
        static Person CreateRandomPerson()
        {
            return new Person(
                infoGen.NextFullName(),//random imya, Next doljen bit
                infoGen.Next(1, 10),
                infoGen.Next(1, 10),
                infoGen.Next(1, 10));
        }
        static void PrintList(List<Person> people)//vizozivaet List<Person>
        {
            foreach (Person item in people)//pokazivaet iz Lista
            {
                Console.WriteLine(item);
            }
        }




    }
}
