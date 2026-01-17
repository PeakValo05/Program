// See https://aka.ms/new-console-template for more information

// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using FloodFillRecursion.Models;

/*Jackson Wiser
  * CST-250
  * 1/18/2026
  * Factorial Recurssion
  * Activity 3
  */
//-------------------------------------------------------------------------------------------------------------------
//Start of Main method
//-------------------------------------------------------------------------------------------------------------------

/// <summary>
/// Main method for testing the BoardModel and Utility class.
/// 
/// Note: the assignment text shows creating a BoardModel with only one argument (size), 
/// but the actual BoardModel class constructor requires two parameters: size and numShapes.
/// - 20 = board size
/// - 3 = number of shapes
/// 
/// This ensures the compiles and runs correctly while still following the assignment requirments
/// </summary>
// Declare and initialize
// Create a new BoardModel
BoardModel board = new BoardModel(20, 3);

Utility.PrintBoard(board);

board = Utility.FloodFill(board, 0, 0);

Utility.PrintBoard(board);


//-------------------------------------------------------------------------------------------------------------------
//End of Main Method
//-------------------------------------------------------------------------------------------------------------------


//-------------------------------------------------------------------------------------------------------------------
//Start of Utility method
//-------------------------------------------------------------------------------------------------------------------

static class Utility
{
    /// <summary>
    /// Print the board to the console
    /// Loops through each row and column of the BoardModel's Grid
    /// and prints the contents of each CellModel.
    /// </summary>
    /// <param name="board">The BoardModel to print</param>

    public static void PrintBoard(BoardModel board)
    {

        //Make sure the color of the column number is white
        Console.ForegroundColor = ConsoleColor.White;
        // Start the column numbers row with a space to keep the numbers aligned
        Console.WriteLine(" ");

        // Loop to add column numbers for the board
        for (int colNum = 0; colNum < board.Size; colNum++)
        {
            // Print the colNum with a 2-character width
            Console.Write($" {colNum + 1, 2}");
        }
        Console.WriteLine();    

        // Loop through the rows of the board
        for (int row = 0; row < board.Size; row++)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"{row + 1,2}");

            // Loop through the columns of the board
            for (int col = 0; col < board.Size; col++)
            {

                // check if the current cell is a wall
                if (board.Grid[row, col].Contents == "W")
                {

                    // Change the text color to red
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" W ");
                }
                else if (board.Grid[row, col].Contents == "E")
                {
                    // Change the text color to white
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" . ");
                }
                else
                {
                    Console.Write("   ");
                }
            }
            // Use a WriteLine to start a new row
            Console.WriteLine();
        }
    }
    internal static BoardModel FloodFill(BoardModel board,  int row, int col) {
        // Declare and initialize
        int sleepCount = 25;
        // Change the text color to white
        Console.ForegroundColor= ConsoleColor.White;
        // Print the current cell to the console
        Console.Write($"Filling at {row}, {col} ");
        // Pause the program for sleepCount number of milliseconds
        Thread.Sleep( sleepCount );

        if (row < 0 || row >= board.Size || col < 0 || col >= board.Size)
        {
            // Print a message indicating the cell is out of bounds
            Console.WriteLine("Out of binds. Stop");
            // Pause the program for sleepCount number of milliseconds
            Thread.Sleep(sleepCount);
            // if the cell is not on the board, end the method
            return board;
        }
        // If the cell is a wall, end the method
        if (board.Grid[row, col].Contents == "F")
        {
            // Print a message indicating the cell is a wall
            Console.WriteLine("Hit a wall. Stop");
            // Pause the program for sleepCount number of milliseconds
            Thread.Sleep(sleepCount);
            return board;
        }
        // If the cell has already been filled, end the method
        else if (board.Grid[row, col].Contents == "F")
        {
            // Print a message indicating the cell already filled
            Console.WriteLine("already Filled. Stop");
            // Pause the program for sleepCount number of milliseconds
            Thread.Sleep(sleepCount);

            return board;
        }
        else
        {
            board.Grid[row, col].Contents = "F";

            Thread.Sleep(sleepCount);
        }

        Console.Clear();

        Console.WriteLine();
        PrintBoard(board);
        // Print a message indicating the next flood fill direction
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("North: ");
        // call the flood fill method to the north
        board = FloodFill(board, row - 1, col);
        // Print a message indicating the next flood fill direction
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("East: ");
        // call the flood fill method to the east
        board = FloodFill(board, row, col + 1);
        // Print a message indicating the next flood fill direction
        Console.ForegroundColor= ConsoleColor.Magenta;
        Console.Write("South: ");
        // call the flood fill method to the south
        board = FloodFill(board, row + 1, col);
        // Print a message indicating the next flood fill direction
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("West: ");
        // call the flood fill method to the west
        board = FloodFill(board, row, col - 1);

        // return the board
        return board;
        // End of FloodFill method

           







        // CHeck if the current cell is a wall
        if (row < 0 || row >= board.Size || col < 0 || col >= board.Size)
        {
            return board;
        }
        if (board.Grid[row, col].Contents == "W")
        {
            return board;
        }
        else if (board.Grid[row, col].Contents == "F")
        {
            return board;
        }
        else
        {
            board.Grid[row, col].Contents = "F";
        }

        // Call the flood fill method to the north
        board = FloodFill(board, row - 1, col);     /* Note: Fix this tomorrow!
                                                     * pattern is not in the right location.
                                                     * fix layout.
                                                    */
        // Call the flood fill method to the east
        board = FloodFill(board, row, col + 1);
        // Call the flood fill nethod to the south
        board = FloodFill(board, row + 1, col);
        // Call the flood fill method to the west
        board = FloodFill(board, row, col - 1);

        // Return the board
        return board;

    } // End of FloodFill method
}








