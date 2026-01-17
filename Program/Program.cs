using System;

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
        // Ask the user for a positive number
        Console.Write("Enter a positive number: ");
        string input = Console.ReadLine();
        int choice;
        int steps = 0;

        // Validate input
        while (!int.TryParse(input, out choice) || choice <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive number.");
            Console.Write("Enter a positive number: ");
            input = Console.ReadLine();
        }

        // Call the recursive function
        int result = Utility.CountToOne(choice, ref steps);

        Console.WriteLine($"\nReached {result}");
    }
}

// Utility class with recursion
static class Utility
{
    internal static int CountToOne(int num, ref int steps)
    {
        steps++;
        Console.WriteLine($" Steps {steps}: Current number = {num}");

        if (num == 1) // base case
            return 1;

        if (num % 2 == 0) // even
        {
            Console.WriteLine("The number is even. Divide by 2");
            return CountToOne(num / 2, ref steps);
        }
        else // odd
        {
            Console.WriteLine("The number is odd. Add 1");
            return CountToOne(num + 1, ref steps); // odd rule: add 1
        }
        
    }
}














