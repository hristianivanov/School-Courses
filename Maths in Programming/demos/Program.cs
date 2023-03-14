namespace demos
{
    public class Program
    {
        static void Main(string[] args)
        {
            double[,] nums = new double[3, 4]
            {
               { 2, -1,  1,  3},
               { 3,  1, -1,  2},
               { 1,  2,  1, -3}
            };
            Console.WriteLine(string.Join(" ", SolveMatrixWithKramer(nums)));
        }
        public static double[] SolveMatrixWithKramer(double[,] matrix)
        {
            int n = matrix.GetLength(0);
            double[] result = new double[n];

            double determinant = DeterminantFromThirdRow(matrix);

            for (int i = 0; i < n; i++)
            {
                double[,] tempMatrix = CopyMatrix(matrix);

                for (int j = 0; j < n; j++)
                    tempMatrix[j, i] = matrix[j, n];

                double tempDeterminant = DeterminantFromThirdRow(tempMatrix);

                result[i] = tempDeterminant / determinant;
            }

            return result.Select(x => Math.Round(x)).ToArray();
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

        private static double[,] CopyMatrix(double[,] matrix)
        {
            int row = matrix.GetLength(0);
            int col = matrix.GetLength(1);
            double[,] result = new double[row, col];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                    result[i, j] = matrix[i, j];
            }

            return result;
        }

    }

}
