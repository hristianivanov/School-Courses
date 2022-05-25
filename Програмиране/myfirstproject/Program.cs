using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstproject
{
    class Program
    {
        static bool Diagonal(int[,] matrix)
        {
            int colons = matrix.GetLength(1);
            int rows = matrix.GetLength(0);
            int n = matrix.Length;
            int leftToRight = 0;
            int rightToLeft = 0;
            for (int i = 0; i < n; i++)
            {
                leftToRight += matrix[i, i];
            }
            for (int i = n; i >= 0; i--)
            {
                rightToLeft += matrix[i, i];
            }
            if (leftToRight == rightToLeft)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n,n];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j] + " ");
                }
                Console.WriteLine();
            }

            int leftToRight = 0;
            int rightToLeft = 0;

            for (int i = 0; i < n; i++)
            {
                leftToRight += matrix[i, i];
            }
            
            int colon = n - 1;
            for (int row = 0; row < n; row++)
            { 
                rightToLeft += matrix[row,colon];
                colon--;
            }




        }
    }
}
