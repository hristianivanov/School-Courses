using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_tac_toe
{
    class Program
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

        static bool CheckX(string[,] matrix)
        {
            int sum = 0;
            for (int i = 0; i < 3; i++)
            {
                if (matrix[i, i].ToUpper() == "X")
                {
                    sum++;
                }
            }
            if (sum == 3)
            {
                return true;
            }

            sum = 0;

            int colon = 2;
            for (int row = 0; row < 3; row++)
            {
                if (matrix[row,colon].ToUpper() == "X")
                {
                    sum++;
                }
                colon--;
            }
            if (sum==3)
            {
                return true;
            }

            sum = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (matrix[i, j].ToUpper()=="X")
                    {
                        sum++;
                    }
                    
                }
                if (sum == 3)
                {
                    return true;
                }
                sum = 0;
            }

            sum = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (matrix[j, i].ToUpper() == "X")
                    {
                        sum++;
                    }
                    
                }
                if (sum == 3)
                {
                    return true;
                }
                sum = 0;
            }

            return false;


        }

        static bool CheckO(string[,] matrix)
        {
            int sum = 0;
            for (int i = 0; i < 3; i++)
            {
                if (matrix[i, i].ToUpper() == "O")
                {
                    sum++;
                }
            }
            if (sum == 3)
            {
                return true;
            }

            sum = 0;

            int colon = 2;
            for (int row = 0; row < 3; row++)
            {
                if (matrix[row, colon].ToUpper() == "O")
                {
                    sum++;
                }
                colon--;
            }
            if (sum == 3)
            {
                return true;
            }

            sum = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (matrix[i, j].ToUpper() == "O")
                    {
                        sum++;
                    }

                }
                if (sum == 3)
                {
                    return true;
                }
                sum = 0;
            }

            sum = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (matrix[j, i].ToUpper() == "O")
                    {
                        sum++;
                    }

                }
                if (sum == 3)
                {
                    return true;
                }
                sum = 0;
            }

            return false;


        }
        static void Main(string[] args)
        {
            string[,] matrix = new string[3, 3];

            for (int row = 0; row < 3; row++)
            {
                List<string> input = Console.ReadLine().Split().ToList();
                for (int inputIndex = 0; inputIndex < 3; inputIndex++)
                {
                    matrix[row, inputIndex] = input[inputIndex];
                }
                input.Clear();

            }

            if (CheckO(matrix))
            {
                Console.WriteLine("The winner is: O");
            }
            if (CheckX(matrix))
            {
                Console.WriteLine("The winner is: X");
            }
            else
            {
                Console.WriteLine("There is no winner");
            }
        }

    }
}
