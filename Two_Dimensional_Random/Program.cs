// Kevin Izykowski
// CIT 134 Fall 2019
// November 1 2019 
// Chapter 8 Exercise three
// Description: Two dimensional array 

using System;

namespace Two_Dimensional

{
    public class Program
    {
        // Generate random number 
        private static Random rand = new Random();
        

        public static void Main(string[] args)
        {
            // Create new array 
            int[,] twoDimensionalArray = new int[10, 12];



            InitializeArray(twoDimensionalArray);
            DisplayArray(twoDimensionalArray); 

        
        }

        // Method to display array
        private static void DisplayArray(int[,] twoDimensionalArray)
        {
            for (int r = 0; r < twoDimensionalArray.GetLength(0); r++)
            {
                for (int c = 0; c < twoDimensionalArray.GetLength(1); c++)
                {
                    Console.Write(twoDimensionalArray[r, c] + " ");
                }
                Console.WriteLine();//space
            }
        }

        // Method to fill array with random numbers
        private static void InitializeArray(int[,] twoDimensionalArray)
        {
            for (int row = 0; row < twoDimensionalArray.GetLength(0); row++)
            {
                for (int col = 0; col < twoDimensionalArray.GetLength(1); col++)
                {
                    if (rand.Next(2) == 0)
                    {
                        twoDimensionalArray[row, col] = rand.Next(1, 1000);
                    }
                    else
                    {
                        twoDimensionalArray[row, col] = rand.Next(1, 1000);
                    }
                }
            }

        }
    }
}
