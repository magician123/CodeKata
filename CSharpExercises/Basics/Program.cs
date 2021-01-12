using System;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();


            Console.Write("Enter the first number :");
            var firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number :");
            var secondNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter the third number :");
            var thirdNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter the fourth number :");
            var fourthNumber = int.Parse(Console.ReadLine());

            var result = calculator.Average(firstNumber,secondNumber,thirdNumber,fourthNumber);

            Console.WriteLine($"The average of {firstNumber} {secondNumber} {thirdNumber} {fourthNumber} is : {result}");

            Console.ReadLine();
        }
    }
}
