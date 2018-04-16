using System;

namespace AboutME
{
    class Program
    {
        public static void NextQuestion()
        {
            Console.WriteLine("\nNext Question");
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Questions questions = new Questions();
            Responses responses = new Responses();
            CityBorn cityBorn = new CityBorn();
            KilingPizza kilingPizza = new KilingPizza();
            Toppings toppings = new Toppings();

            Console.WriteLine(questions.Q1());
            string userName = Console.ReadLine();
            Console.WriteLine(responses.R1(userName));

            Console.ReadKey();

            Console.WriteLine(questions.Q2());
            string answer1 = Console.ReadLine().ToLower();
            Console.WriteLine(cityBorn.City(answer1));
            NextQuestion();

            Console.WriteLine(questions.Q3());
            string answer2 = Console.ReadLine().ToLower();
            Console.WriteLine(kilingPizza.WouldKill(answer2));
            NextQuestion();

            Console.WriteLine(questions.Q4()); ;
            toppings.ToppingTypes();

            Console.WriteLine(responses.R2(userName));
            Console.ReadKey();
        }
    }
}
