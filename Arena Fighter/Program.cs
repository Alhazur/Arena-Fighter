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
            List<Person> people = new List<Person>();
            
            Console.WriteLine("Your name player: ");
            string Player = Console.ReadLine();

            Person me = new Person(Player);
            Person enemy = CreateRandomPerson();//static Person CreateRandomPerson() Klass nazvanie i novoe nazvanie dlya cheloveka!
            Battle battle = new Battle(me, enemy);




            me.Print();
            Console.Clear();
            people.Add(enemy);//a syda zapisat novoe nazvanie k list(enemy)

            while (true)
            {


                battle.StartBattle();






                Console.ReadLine();


                Console.ReadKey();

            }
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
