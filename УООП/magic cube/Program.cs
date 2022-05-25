using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magic_cube
{
    
    class Program
    {
        static int Colons(int[,] matrix)
        {
            int colons = matrix.GetLength(1);
            int rows = matrix.GetLength(0);
            int sum = 0;
            for (int i = 0; i < colons; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    sum += matrix[j, i];
                }
            }
            return sum;

        }
        static int Rows(int[,] matrix)
        {
            int colons = matrix.GetLength(1);
            int rows = matrix.GetLength(0);
            int sum = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colons; j++)
                {
                    sum += matrix[i, j];
                }
            }
            return sum;
        }
        static bool Diagonal(int[,] matrix)
        {
            int colons = matrix.GetLength(1);
            int rows = matrix.GetLength(0);
            int n = matrix.GetLength(0);
            int leftToRight = 0;
            int rightToLeft = 0;
            for (int i = 0; i < n; i++)
            {
                leftToRight += matrix[i, i];
            }
            for (int i = n; i >=0; i--)
            {
                rightToLeft += matrix[i, i];
            }
            if (leftToRight==rightToLeft)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool MagicCube(int[,] matrix)
        {
            if (Colons(matrix)==Rows(matrix))
            {
                if (Diagonal(matrix))
                {
                    return true;
                }
            }
            
                return false;
            
        }
        static void Main(string[] args)
        {
            Console.Write($"Enter n : ");
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n,n];

            //Console.Write($"Enter rows values : ");
            var inputRows = Console.ReadLine().Split(' ').Skip(4).Select(int.Parse).ToArray();

            for (int rows = 0; rows < n; rows++)
            {

                for (int colons = 0; colons < n; colons++)
                {
                    matrix[rows, colons] = int.Parse(Console.ReadLine());
                }

            }
            if (MagicCube(matrix))
            {
                Console.WriteLine("Matrix is Magic Cube.");
            }
            else
            {
                Console.WriteLine("Matrix is not a Magic Cube.");
            }

        }
    }
}
