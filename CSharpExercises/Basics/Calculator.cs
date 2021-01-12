using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
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
    public class Calculator
    {
        public int Average(int firstNumber, int secondnumber, int thirdNumber, int fourthNumber)
        {
            return (firstNumber + secondnumber + thirdNumber + fourthNumber) / 4;
        }

    }
}
