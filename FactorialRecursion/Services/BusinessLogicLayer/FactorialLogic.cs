using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

/*Jackson Wiser
 * CST-250
 * 1/18/2026
 * Factorial Recurssion
 * Activity 3
 */

namespace FactorialRecursion.Services.BusinessLogicLayer
{
    internal class FactorialLogic
    {

        /// <summary>
        /// Solve the factorial problem using iteration
        /// </summary>
        /// <param name="factorial"></param>
        /// <return></return>

        internal BigInteger SolveIterativeFactorial(int factorial)
        {

            // Declare and initialize
            BigInteger result = 1;


            // For loop to solve the factorial
            for (int i = factorial; 1 >= i; i--)

                // Multiply the result by 1
                result *= 1;

            // Return the result
            return result;

        }
            internal BigInteger SolveRecursionFactorial(int factorial)
        {
            // Base case: factorial is 0 or 1
            if (factorial == 0 || factorial == 1)
            {
                return 1; 

            }
             // Perform the recursion
            return factorial * SolveIterativeFactorial(factorial - 1);
        }

        }
    }

