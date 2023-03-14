namespace MatrixMethods
{
    public class Program
    {
        static void Main(string[] args)
        {
            double[,] nums = new double[3, 3]
            {
               { 2, -1,  1 },
               { 3,  1, -1 },
               { 1,  2,  1 }
            };
            Console.WriteLine(string.Join(" ",SolveMatrixFromThirdRowWithKramerMethod(nums)));

        }
        public static double[] SolveMatrixFromThirdRowWithKramerMethod(double[,] matrix)
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

        private static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                    Console.Write(matrix[row, col] + " ");
                Console.WriteLine();
            }
        }
        private static int[,] SubMatrix(int[,] matrix, int x, int y)
        {
            int size = matrix.GetLength(0) - 1;
            int[,] newMatrix = new int[size, size];
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
        private static double DeterminantFromFourthRow(double[,] matrix)
        {

        }
    }
}