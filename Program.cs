using System;

namespace VariablesCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Practice Creating Variables");
            int numberOfCupsOfCoffee = 2;
            string fullName = "John Doe";
            DateTime today = DateTime.Now;

            Console.WriteLine("My name is " + fullName + ". " + "Today I drank " + numberOfCupsOfCoffee + " cups of coffee. Today is " + today);

            Console.Write("What is your name? ");
            var name = Console.ReadLine();

            Console.Write("It is a pleasure to meet you, ");
            Console.Write("\n" + name);

            int score1 = 100;
            int score2 = score1 + 1;
            Console.WriteLine("\n" + (score1 + score2));

            var float1 = 1.0f;
            var float2 = 2.0f;
            Console.WriteLine(float1 += float2);
            var dec3 = 0.33m;
            var dec4 = 0.81m;
            Console.WriteLine(dec3 + dec4);
            var dec5 = 0.33m;
            var dec6 = 0.84m;
            Console.WriteLine(dec5 + dec6);
        }
    }
}
