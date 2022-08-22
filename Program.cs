using System;

namespace VariablesCS
{
    class Program
    {
        static void Main(string[] args)
        {
            //********* Practice Creating Variables **********

            // Create a variable(use your best judgment for type) that stores the numberOfCupsOfCoffee that you drink every day.
            int numberOfCupsOfCoffee = 2;
            // Create a variable(use your best judgment for type) called fullName and set it equal to your full name.
            string fullName = "John Doe";
            // Create a variable(use your best judgment for type) called today and set it equal to today's date.
            var today = DateTime.Today;
            var todayDay = today.DayOfWeek;
            // Use Console.WriteLine and your variables, numberOfCupsOfCoffee, fullName, and today, to output all three on one line.
            Console.WriteLine($"{fullName} had {numberOfCupsOfCoffee} cups of coffee today, {todayDay} {today}");

            //******** Practice Getting Input From the User **********

            // Ask the user for their name and store it in a variable named userName.
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            // Print out a greeting to the user, using their name.
            Console.WriteLine($"Hello {userName}");

            //******** Practice Getting Different Types of Input From the User **********
            // Ask the user for their age and store it in a variable named userAge.
            Console.WriteLine("What is your age?");
            int userAge = int.Parse(Console.ReadLine());
            // Ask the user for their favorite color and store it in a variable named userColor.
            Console.WriteLine("What is your favorite color?");
            string userColor = Console.ReadLine();
            // Ask the user for their favorite animal and store it in a variable named userAnimal.
            Console.WriteLine("What is your favorite animal?");
            string userAnimal = Console.ReadLine();
            // Ask the user for their favorite food and store it in a variable named userFood.
            Console.WriteLine("What is your favorite food?");

            // Ask the user to input 1st number.
            Console.WriteLine("Enter one number.");
            string firstNumberAsString = Console.ReadLine();
            if (string.IsNullOrEmpty(firstNumberAsString))
            {
                Console.WriteLine("Please enter a valid number.");
                // userInput1 = Console.ReadLine();
                // if (firstNumberAsString == null && firstNumberAsString == "")
                // {
                //     Console.WriteLine("Please enter two numbers separated by a space.");
                // }
            }
            // Ask the user to input 2nd number
            Console.WriteLine("Enter another number.");
            string secondNumberAsString = Console.ReadLine();
            if (string.IsNullOrEmpty(secondNumberAsString))
            {
                Console.WriteLine("Please enter a valid number.");
                // userInput2 = Console.ReadLine();
                // if (secondNumberAsString == null && secondNumberAsString == "")
                // {
                //     Console.WriteLine("Please enter second number");
                // }
            }
            //******** Converting String Input Into Numbers ********
            // Convert each string above to a double using double.Parse.Save the first value in a variable named firstOperand and the second value in a variable named secondOperand.
            double firstOperand = double.Parse(firstNumberAsString);
            double secondOperand = double.Parse(secondNumberAsString);
            // Use Console.WriteLine to output the sum.
            Console.WriteLine($"{firstOperand} + {secondOperand} = {firstOperand + secondOperand}");
            // Use Console.WriteLine to output the difference.
            Console.WriteLine($"{firstOperand} - {secondOperand} = {firstOperand - secondOperand}");
            // Use Console.WriteLine to output the product.
            Console.WriteLine($"{firstOperand} * {secondOperand} = {firstOperand * secondOperand}");
            // Use Console.WriteLine to output the quotient.
            Console.WriteLine($"{firstOperand} / {secondOperand} = {firstOperand / secondOperand}");
            // Use Console.WriteLine to output the remainder or modulus.
            Console.WriteLine($"{firstOperand} % {secondOperand} = {firstOperand % secondOperand}");






            //******** Doing Math

            // Add the operand variables from above and save the results in a variable named sum.
            // Subtract the secondOperand variable from the firstOperand variable and save the results in a variable named difference.
            // Multiply the operand variables and save the results in a variable named product.
            // Divide the firstOperand by the secondOperand and save the results in a variable named quotient.
            // Find the remainder when one operand is divided by the other and save the results in a variable named remainder. See this page if you need to learn more about the modulo operator.
            // Use Console.WriteLine to present the user, in a meaningful way, each of the values for the sum, difference, quotient, product, and remainder variables. (e.g. perhaps one of your outputs is similar to If you add 4 and 5 you get 9 if 4 and 5 were the input)

            //******** Using Logic
            // Add some logic to your program that prints a different, special, greeting to the user if their name happens to be Alice.
            // Using DateTime
            // Use the type DateTime to represent the date variables.
            // See the lesson on variables for some guidance on DateTime.

            // Move all of your code to a separate method (but keep it in the same file) and invoke it from the Main method.



        }
    }
}
