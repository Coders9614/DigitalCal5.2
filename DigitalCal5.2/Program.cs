using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalCal5._2
{
    public class DigitSumCalculator
    {
        // Function to calculate the sum of the digits of a given number
        public int SumOfDigits(int number)
        {
            int sum = 0;

            // Loop to extract and sum each digit
            while (number != 0)
            {
                int digit = number % 10; // Extract the last digit
                sum += digit; // Add the digit to the sum
                number /= 10; // Remove the last digit from the number
            }

            return sum;
        }

        public static void Main(string[] args)
        {
            DigitSumCalculator calculator = new DigitSumCalculator();

            // Prompt the user to enter a number
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            // Calculate the sum of the digits
            int result = calculator.SumOfDigits(number);

            // Display the result
            Console.WriteLine($"The sum of the digits of the number {number} is: {result}");
            Console.ReadKey();
        }
    }
}
