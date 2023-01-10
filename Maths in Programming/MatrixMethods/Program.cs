namespace MatrixMethods
{
    public class Program
    {
        static void Main(string[] args)
        {
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
        private static double DeterminantFromThirdRow(int[,] matrix)
        {
            int row = 0, col = 0;
            if (matrix.GetLength(0) == 3 && matrix.GetLength(1) == 3)
                return matrix[row, col] * matrix[row + 1, col + 1] * matrix[row + 2, col + 2] +
                    matrix[row, col + 1] * matrix[row + 1, col + 2] * matrix[row + 2, col] +
                    matrix[row, col + 2] * matrix[row + 1, col] * matrix[row + 2, col + 1] -
                    matrix[row, col + 2] * matrix[row + 1, col + 1] * matrix[row + 2, col] -
                    matrix[row, col] * matrix[row + 1, col + 2] * matrix[row + 2, col + 1] -
                    matrix[row, col + 1] * matrix[row + 1, col] * matrix[row + 2, col + 2];
            else
                throw new InvalidOperationException("Invalid matrix lenght!");
        }
        //private static double DeterminantFromFourthRow(int[,] matrix)
        //{

        //}
    }
}