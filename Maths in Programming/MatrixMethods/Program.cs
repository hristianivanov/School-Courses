using Microsoft.VisualBasic;
using System.Numerics;

namespace MatrixMethods
{
    public class Program
    {
        static void Main(string[] args)
        {
            double[,] matrix = new double[4, 4]
        {
                {1, 2, -2, 3},
                {-1, 1, 0, 2},
                {3, -3, 4, 1},
                {2, 1, 1, -2}
        };
            Console.WriteLine(string.Join(" ", SolveMatrixFromFourthRowWithKramerMethod(matrix, new double[] { 2, -3, 16, 9 })));
        }
        private static double[] SolveMatrixFromThirdRowWithKramerMethod(double[,] matrix)
        {
            int n = matrix.GetLength(0);
            double[] result = new double[n];
            double determinant = DeterminantFromThirdRow(matrix);

            for (int i = 0; i < n; i++)
            {
                double[,] tempMatrix = CopyMatrix(matrix);

                for (int j = 0; j < n; j++)
                    tempMatrix[j, i] = matrix[j, n - 1];

                double tempDeterminant = DeterminantFromThirdRow(tempMatrix);
                result[i] = tempDeterminant / determinant;
            }

            return result;
        }
        private static double[] SolveMatrixFromFourthRowWithKramerMethod(double[,] matrix, double[] constants)
        {
            double detMainMatrix = DeterminantFromFourthRow(matrix);

            if (detMainMatrix == 0)
                throw new ArgumentException("The matrix has no unique solution.");

            double[] detCoefficients = new double[4];

            for (int i = 0; i < 4; i++)
                detCoefficients[i] = DeterminantFromFourthRow(ChangeMatrix(matrix, constants, i));

            double[] solutions = new double[4];
            for (int i = 0; i < 4; i++)
                solutions[i] = detCoefficients[i] / detMainMatrix;

            return solutions.Select(x => Math.Round(x)).ToArray();
        }
        private static double[,] ChangeMatrix(double[,] matrix, double[] constants, int col)
        {
            if (constants.Length != matrix.GetLength(1))
                throw new InvalidOperationException();

            double[,] newMatrix = CopyMatrix(matrix);

            for (int row = 0; row < matrix.GetLength(0); row++)
                newMatrix[row, col] = constants[row];

            return newMatrix;
        }
        private static double[,] CopyMatrix(double[,] matrix)
        {
            int n = matrix.GetLength(0);
            double[,] result = new double[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    result[i, j] = matrix[i, j];
            }
            return result;
        }
        private static int[,] CreateMatrix(int n)
        {
            int[,] matrix = new int[n, n];
            for (int row = 0; row < n; row++)
            {
                int[] nums = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < n; col++)
                    matrix[row, col] = nums[col];
            }
            return matrix;
        }
        private static void PrintMatrix(double[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                    Console.Write(matrix[row, col] + " ");
                Console.WriteLine();
            }
        }
        private static double[,] SubMatrix(double[,] matrix, int x, int y)
        {
            int size = matrix.GetLength(0) - 1;
            double[,] newMatrix = new double[size, size];
            int newRow = 0, newCol = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (x == row || y == col)
                        continue;
                    newMatrix[newRow, newCol] = matrix[row, col];
                    newRow++;
                    newCol++;
                }
            }
            return newMatrix;
        }
        private static double DeterminantFromSecondRow(int[,] matrix)
        {
            int row = 0, col = 0;
            if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
                return matrix[row, col] * matrix[row + 1, col + 1] - matrix[row + 1, col] * matrix[row, col + 1];
            else
                throw new InvalidOperationException("Invalid matrix lenght!");
        }
        private static double DeterminantFromThirdRow(double[,] matrix)
        {
            var det = 0.0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                det = det + (matrix[0, i] * (matrix[1, (i + 1) % 3] * matrix[2, (i + 2) % 3]
                    - matrix[1, (i + 2) % 3] * matrix[2, (i + 1) % 3]));
            }
            return det;
        }
        public static double DeterminantFromFourthRow(double[,] matrix)
        {
            double det = 0;
            int n = matrix.GetLength(0);

            if (n == 1)
                det = matrix[0, 0];
            else if (n == 2)
                det = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
            else
            {
                for (int i = 0; i < n; i++)
                {
                    double[,] submatrix = new double[n - 1, n - 1];
                    for (int j = 1; j < n; j++)
                    {
                        for (int k = 0, m = 0; k < n; k++)
                        {
                            if (k == i)
                                continue;

                            submatrix[j - 1, m] = matrix[j, k];
                            m++;
                        }
                    }
                    double sign = (i % 2 == 0) ? 1 : -1;
                    det += sign * matrix[0, i] * DeterminantFromFourthRow(submatrix);
                }
            }
            return det;
        }
    }
}