using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotary_ticket
{
    class Program
    {
        static bool DiagonalSum(int[,] matrix)
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

            int colon = n - 1;

            for (int row = 0; row < n; row++)
            {
                rightToLeft += matrix[row, colon];
                colon--;
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

        static bool EvenDiagonal(int[,] matrix)
        {
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if ( j > i)
                    {
                        sum += matrix[i, j];
                    }
                }
            }

            if (sum%2==0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        static bool OddDiagonal(int[,] matrix)
        {
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j < i)
                    {
                        sum += matrix[i, j];
                    }
                }
            }

            if (sum % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        //static bool WinningTicket(int[,] matrix)
        //{
        //    if ( DiagonalSum( matrix) )
        //    {
        //        if ( EvenDiagonal(matrix) )
        //        {
        //            if ( OddDiagonal(matrix) )
        //            {
        //                return true;
        //            }
        //        }
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n,n];

            for (int rows = 0; rows < n; rows++)
            {

                for (int colons = 0; colons < n; colons++)
                {

                    matrix[rows, colons] = int.Parse(Console.ReadLine());

                }

            }

            int sum = 0;

            if (DiagonalSum(matrix))
            {
                if (EvenDiagonal(matrix))
                {
                    if (OddDiagonal(matrix))
                    {
                        Console.WriteLine("YES");

                        for (int rows = 0; rows < n; rows++)
                        {

                            for (int colons = 0; colons < n; colons++)
                            {

                                if (rows>colons)
                                {
                                    sum += matrix[rows, colons];
                                }
                                if (rows==colons && matrix[rows,colons]%2==0)
                                {
                                    sum += matrix[rows, colons];
                                }
                                if (rows==0 || rows+1==n)
                                {

                                    if (matrix[rows,colons]%2==0)
                                    {
                                        sum += matrix[rows, colons];
                                    }
                                    
                                }
                                if (colons==0 || colons+1==n)
                                {

                                    if (matrix[rows,colons]%2 != 0)
                                    {
                                        sum += matrix[rows, colons];
                                    }
                                }
                            }

                        }

                        Console.WriteLine($"{sum:f2}");
                    }

                }
            }
            else
            {
                Console.WriteLine("NO");
            }



        }
    }
}
