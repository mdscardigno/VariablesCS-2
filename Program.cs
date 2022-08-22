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

            //check to see if the user entered nothing, whitespace or a number. 
            var num = -1;
            while (string.IsNullOrEmpty(userName) || string.IsNullOrWhiteSpace(userName) || int.TryParse(userName, out num))
            {
                Console.WriteLine("Please enter your name.");
                userName = Console.ReadLine();
            }
            // Print out a greeting to the user, using their name.
            //make a method for this called greeting
            Console.WriteLine($"Hello {userName}");

            //******** Practice Getting Different Types of Input From the User **********
            // Ask the user for their age and store it in a variable named userAge.

            Console.WriteLine("What is your age?");
            string userAge = Console.ReadLine();
            int inputAgeValue;
            bool correctInputValue = int.TryParse(userAge, out inputAgeValue);
            bool valid = correctInputValue && inputAgeValue >= 0;
            while (!valid)
            {
                Console.WriteLine("Invalid input. Try again...");
                userAge = Console.ReadLine();
                correctInputValue = int.TryParse(userAge, out inputAgeValue);
                valid = correctInputValue && inputAgeValue >= 0;
            }
            Console.WriteLine($"You entered: {inputAgeValue}");

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
            while (string.IsNullOrEmpty(firstNumberAsString) || string.IsNullOrWhiteSpace(firstNumberAsString) || !int.TryParse(firstNumberAsString, out num))
            {
                Console.WriteLine("No number was entered. Please try again.");
                firstNumberAsString = Console.ReadLine();

            }
            Console.WriteLine($"You entered: {firstNumberAsString}");

            // Ask the user to input 2nd number
            Console.WriteLine("Enter another number.");
            string secondNumberAsString = Console.ReadLine();
            while (string.IsNullOrEmpty(secondNumberAsString) || string.IsNullOrWhiteSpace(secondNumberAsString) || !int.TryParse(secondNumberAsString, out num))
            {
                Console.WriteLine("No number was entered. Please try again.");
                secondNumberAsString = Console.ReadLine();
            }
            Console.WriteLine($"You entered: {secondNumberAsString}");

            Console.WriteLine("Press enter to see results.");
            Console.ReadKey();

            //******** Converting String Input Into Numbers ********
            // Convert each string above to a double using double.Parse.Save the first value in a variable named firstOperand and the second value in a variable named secondOperand.
            var firstOperand = double.Parse(firstNumberAsString);
            var secondOperand = double.Parse(secondNumberAsString);

            //******** Doing Math with Variables ********
            // Add the operand variables from above and save the results in a variable named sum.
            var sum = firstOperand + secondOperand;
            // Use Console.WriteLine to output the sum.
            Console.WriteLine($"{firstOperand} + {secondOperand} = {sum}");

            // Subtract the secondOperand variable from the firstOperand variable and save the results in a variable named difference.
            var difference = firstOperand - secondOperand;
            // Use Console.WriteLine to output the difference.
            Console.WriteLine($"{firstOperand} - {secondOperand} = {difference}");

            // Multiply the operand variables and save the results in a variable named product.
            var product = firstOperand * secondOperand;
            // Use Console.WriteLine to output the product.
            Console.WriteLine($"{firstOperand} * {secondOperand} = {product}");

            // Divide the firstOperand by the secondOperand and save the results in a variable named quotient.
            var quotient = firstOperand / secondOperand;
            // Use Console.WriteLine to output the quotient.
            Console.WriteLine($"{firstOperand} / {secondOperand} = {quotient}");

            // Find the remainder when one operand is divided by the other and save the results in a variable named remainder. See this page if you need to learn more about the modulo operator.
            var remainder = firstOperand % secondOperand;
            // Use Console.WriteLine to output the remainder (left over) or modulus.
            Console.WriteLine($"{firstOperand} % {secondOperand} = {remainder}");

            //******** Using Logic
            // Add some logic to your program that prints a different, special, greeting to the user if their name happens to be Alice.
            // Using DateTime
            // Use the type DateTime to represent the date variables.
            var todaysDay = DateTime.Now.Hour;
            Console.WriteLine($"Today at exactly, {todaysDay}, I learned that some lipsticks contain fish scales! /n And there are 293 ways to make change for a dollar. ");

            // Move all of your code to a separate method (but keep it in the same file) and invoke it from the Main method.
        }
    }
}
