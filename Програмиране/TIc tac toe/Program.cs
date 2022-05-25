using System;
using System.Linq;

namespace TIc_tac_toe
{
    class Program
    {
        static void Main(string[] args)
        {
            static void PrintMatrix(string[,] matrix)
            {
                for (int row = 0; row < matrix.Length; row++)
                {
                    for (int col = 0; col < matrix.Length; col++)
                    {
                        Console.Write(matrix[row, col]);
                    }
                    Console.WriteLine();
                }
            }
            static void Main(string[] args)
            {
                string[,] matrix = new string[3, 3];

                for (int row = 0; row < 3; row++)
                {
                    string[] input = Console.ReadLine().Split().ToArray();
                    for (int inputIndex = 0; inputIndex < 3; inputIndex++)
                    {
                        matrix[row, inputIndex] = input[inputIndex];
                    }
                    

                }

                PrintMatrix(matrix);

            }
        }
    }
}
