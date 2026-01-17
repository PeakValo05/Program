// See https://aka.ms/new-console-template for more information
using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        /*Jackson Wiser
        * CST-250
        * 1/18/2026
        * Factorial Recurssion
        * Activity 3
        */

        //-------------------------------------------------------------------------------------------------------------------
        //Start of Main Method
        //-------------------------------------------------------------------------------------------------------------------


        int number1 = 0, number2 = 0;

        while (true)
        {
            Console.Write("Enter the first positive number: "); // Enter positive number
            string input1 = Console.ReadLine();
            if (int.TryParse(input1, out number1) && number1 > 0)
                break;
            Console.WriteLine("Invalid input. Please enter a positive integer"); // When user enters in an invalid number system errors
        }

        while (true)
        {
            Console.Write("Enter the second positive number: "); // User enters a second positive number 
            string input2 = Console.ReadLine();
            if (int.TryParse(input2, out number2) && number2 > 0)
                break;
            Console.WriteLine("Invalid input. Please enter a positive intenger"); // When user enters in an invalid number system errors
        }
        int result = Utility.GreatestCommonDivisor(number1, number2);
        Console.WriteLine($"\nThe GCD of {number1} and {number2} is {result}");

        // ------------------------- Time Comparison --------------
        Stopwatch sw = Stopwatch.StartNew();
        int recursiveResult = Utility.GreatestCommonDivisor(number1, number2);
        sw.Stop();

        Console.WriteLine($"\nRecursion GCD: {recursiveResult}");
        Console.WriteLine($"Recursive Time: {sw.ElapsedTicks} ticks");

        sw.Restart();
        int iterativeResult = Utility.IterativeGCD(number1, number2);
        sw.Stop();

        Console.WriteLine($"\nIterative GCD: {iterativeResult}");
        Console.WriteLine($"Iterative Time: {sw.ElapsedTicks} ticks");

        while (true)
        {
            Console.WriteLine("Enter a positive number: "); // enter a posotive number
            string input = Console.ReadLine();
            if (int.TryParse(input, out number1) && number1 > 0) {
                break;
                Console.WriteLine("Invalid input. Number must be positive and non-zero"); // Must be positive and no zeros
            }
        }
    }



    //-------------------------------------------------------------------------------------------------------------------
    //End of Main Method
    //-------------------------------------------------------------------------------------------------------------------
    public class Utility
    {
        ///<summary>
        ///Calculate the GCD using recursion
        ///</summary>
        ///<param name="=num1"></param>
        ///<param name="=num2"></param>
        ///<return></return>

        internal static int GreatestCommonDivisor(int num1, int num2)
        {
            int remainder = 0; // Declare and initialize

            if (num1 == 0 || num2 == 0) // Base case: num2 is 0
            {
                return num1; // Return the greatest common divisor
            }
            else
            {
                // get the remainder of dividing num1 and num2
                remainder = num1 % num2;
                // print an update to the user
                Console.WriteLine($"Not yet. The remainder of {num1} and {num2} is {remainder}");
                // call the recursion function of the second number and the remainder
                return GreatestCommonDivisor(num2, remainder);
            }
        }
        internal static int IterativeGCD(int num1, int num2)
        {
            var divisors1 = new List<int>();
            var divisors2 = new List<int>();

            // Find all divisors for num1
            for (int i = 1; i <= num1; i++)
            {
                if (num1 % i == 0)
                    divisors1.Add(i);
            }

            // Find all divisors for num2
            for (int i = 1; i <= num2; i++)
            {
                if (num2 % i == 0)
                    divisors2.Add(i);
            }

            // Find the largest common divisor
            int gcd = 1;
            foreach (int d in divisors1)
            {
                if (divisors2.Contains(d))
                    gcd = d;
            }

            return gcd;
        }
        internal static int GCDMultiple(params int[] numbers)
        {
            if (numbers.Length < 2)
                throw new ArgumentException("Need at least two numbers");

            int result = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                result = GreatestCommonDivisor(result, numbers[i]);
            }
            return result;

        }
    }
}

