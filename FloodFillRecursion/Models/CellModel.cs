using System;
using System.Collections.Generic;
using System.Text;

    /*Jackson Wiser
     * CST-250
     * 1/18/2026
     * Factorial Recurssion
     * Activity 3
     */

namespace FloodFillRecursion.Models
{
    internal class CellModel
    {
        // Cell Model Properties
        public int Row {  get; set; }
        public int Col { get; set; }    
        public string Contents { get; set; }

        /// <sumary>
        /// Parameterized constructor for CellModel
        /// </sumary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <param name="contents"></param>
        
        public CellModel(int row, int column, string contents) { 

            Row = row;
            Col = column;
            Contents = contents;
        
        
        }
    }
}
