using System;

namespace AdditionProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Addition Program");

            Console.WriteLine("Enter the first number:");
            string firstNumberInput = Console.ReadLine();

            Console.WriteLine("Enter the second number:");
            string secondNumberInput = Console.ReadLine();

            // Convert the user inputs to numbers
            if (double.TryParse(firstNumberInput, out double firstNumber) && double.TryParse(secondNumberInput, out double secondNumber))
            {
                double result = firstNumber + secondNumber;
                Console.WriteLine($"The sum of {firstNumber} and {secondNumber} is: {result}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter valid numbers.");
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
