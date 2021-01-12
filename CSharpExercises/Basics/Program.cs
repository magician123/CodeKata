using System;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberOfOnesViewer();
        }

        static void NumberOfOnesViewer()
        {
            Calculator calculator = new Calculator();

            Console.Write("how many numbers do whant to enter?");
            var numberOfIndex =int.Parse(Console.ReadLine());

            int[] array = new int[numberOfIndex];

            for (int i = 0; i < numberOfIndex; i++)
            {
                Console.WriteLine($"Enter number {i + 1}");
                var number = int.Parse(Console.ReadLine());

                array[i] = number;
            }

            Console.WriteLine($"The number of 1's are {calculator.NumberOfOnes(array)}");
            Console.ReadLine();
        }
        static void AveraageViewier()
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

            var result = calculator.Average(firstNumber, secondNumber, thirdNumber, fourthNumber);

            Console.WriteLine($"The average of {firstNumber} {secondNumber} {thirdNumber} {fourthNumber} is : {result}");

            Console.ReadLine();
        }
    }
}
