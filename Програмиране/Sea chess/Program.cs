using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_tac_toe
{
    class Program
    {
        static void PrintMatrix (int[,] matrix)
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix.Length; col++)
                {
                    Console.Write(matrix[row,col]);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[,] matrix = new int[3, 3];

            for (int row = 0; row < matrix.Length; row++)
            {
                var input = Console.ReadLine().Split().ToArray();
                for (int col = 0; col < input.Length; col++)
                {
                    matrix[row, col] = input[col];
                }
                Console.WriteLine();
 
                
            }

            PrintMatrix(matrix);

        }
    }
}
