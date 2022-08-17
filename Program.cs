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
            Console.Write(name);

            int score1 = 100;
            int score2 = score1 + 1;
            Console.WriteLine(score1 + score2);
        }
    }
}
