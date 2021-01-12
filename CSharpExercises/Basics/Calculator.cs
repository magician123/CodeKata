using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{

    public class Calculator
    {
        /// <summary>
        /// Write a C# Sharp program that takes four numbers as input to calculate and print the average. Go to the editor
        ///Test Data:
        ///Enter the First number: 10
        ///Enter the Second number: 15
        ///Enter the third number: 20
        ///Enter the four number: 30
        ///Expected Output:
        ///he average of 10 , 15 , 20 , 30 is: 18
        /// </summary>
        public int Average(int firstNumber, int secondnumber, int thirdNumber, int fourthNumber)
        {
            return (firstNumber + secondnumber + thirdNumber + fourthNumber) / 4;
        }


        public int NumberOfOnes(int[] array)
        {
            int counter = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 1)
                    counter++;
            }

            return counter;
        }
    }
}
