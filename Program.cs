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
            var userName = Console.ReadLine();

            Console.Write("It is a pleasure to meet you, " + userName + ". ");
            //single line comment 
            /* multi line comment */
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

            Console.Write("Enter the magic name to play a cool game: ");
            var checkingName = Console.ReadLine().ToUpper();
            if (checkingName == "Alice".ToUpper())
            {
                Console.WriteLine("Welcome to the cool game of math. \n Pick one number: ");
                var firstNumber = Double.Parse(Console.ReadLine());
                //string interpolation
                Console.WriteLine($"You picked: {firstNumber}");
                Console.WriteLine("Pick a second number: ");
                var secondNumber = Int32.Parse(Console.ReadLine());
                Console.WriteLine($"You picked: {secondNumber}");

                var sum = firstNumber + secondNumber;
                Console.WriteLine($"The first number and second number added together equals: {sum}");
                var difference = firstNumber - secondNumber;
                Console.WriteLine($"Subtracting the second number  from the first number equals: {difference}");
                var product = firstNumber * secondNumber;
                Console.WriteLine($"Multiplying the first number by the second number equals: {product}");
                var quotient = firstNumber / secondNumber;
                Console.WriteLine($"Dividing the first number by the second number equals: {quotient}");
                var modulus = firstNumber % secondNumber;
                Console.WriteLine($"The remainder of the first number divided by the second number equals: {modulus}");
            }
            else
            {
                Console.WriteLine("Too bad. Access denied.");
            }

        }
    }
}
