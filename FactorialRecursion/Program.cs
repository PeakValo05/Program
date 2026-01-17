// See https://aka.ms/new-console-template for more information
/*Jackson Wiser
 * CST-250
 * 1/18/2026
 * Factorial Recurssion
 * Activity 3
 */

//-------------------------------------------------------------------------------------------------------------------
//Start of Main method
//-------------------------------------------------------------------------------------------------------------------

using FactorialRecursion.Services.BusinessLogicLayer;
using System.Numerics;

// Declare and initialize
FactorialLogic factorialLogic = new FactorialLogic();
int input = 0;
BigInteger iterativeAns = 0, recursionAns = 0;

// Prompt the user
Console.Write("Enter a positive number");
// Get the users input
input = Utility.ReadIntFromConsole();

Console.WriteLine("Solving the factorial using iteration...");
iterativeAns = factorialLogic.SolveIterativeFactorial(input);
Console.WriteLine($"Answer: {iterativeAns}");

//-------------------------------------------------------------------------------------------------------------------
//End of Main Method
//-------------------------------------------------------------------------------------------------------------------

static class Utility
{
    /// <summary>
    /// Read integer input from the console
    /// </summary>
    /// <return></return>
   
    internal static int ReadIntFromConsole()
    {
        string input = "";
        int number = -1;


        // Get the current input
        input = Console.ReadLine();
        // check if the input is valid
        while (!int.TryParse(input, out number))
        {
            Console.WriteLine("Invalid input, PLease try again"); // show the user an error message and prompt them again

            input = Console.ReadLine(); // Get the new input
        }
        // returns the resulting integer from the user
        return number;
    }

}







