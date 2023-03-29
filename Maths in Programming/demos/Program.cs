namespace demos;

internal class Program
{
    static void Main(string[] args)
    {
        int[,] ints = GenerateMatrix();

        Console.WriteLine("Results");
        int[] results = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        Console.WriteLine();
        Console.WriteLine("Original Matrix");

        PrintMatrix(ints);

        int[,] originalMatrix = ints;

        double originalDelta = DeltaFourRow(ints, 0);

        Console.WriteLine("Original delta = {0}", originalDelta);

        double[] unknowns = new double[4];

        for (int col = 0; col < ints.GetLength(0); col++)
        {
            unknowns[col] = DeltaFourRow(ChangeMatrix(originalMatrix, col, results), col);

            Console.WriteLine($"x{col + 1} = {(int)(unknowns[col] / originalDelta)}");
        }

    }


    public static double DeltaFourRow(int[,] ints, int row)
    {
        double result = 0;

        for (int col = 0; col < ints.GetLength(0); col++)
        {
            result += ints[row, col] * Math.Pow(-1, col + 2) * Delta(SubMatrix(row, col, ints));
        }

        return result;
    }
    public static int[,] ChangeMatrix(int[,] matrix, int col, int[] results)
    {
        int[,] outputMatrix = new int[4, 4];

        for (int r = 0; r < matrix.GetLength(0); r++)
        {
            for (int c = 0; c < matrix.GetLength(0); c++)
            {
                outputMatrix[r, c] = matrix[r, c];
            }
        }

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            outputMatrix[row, col] = results[row];
        }

        return outputMatrix;
    }
    public static void PrintMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,4}", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
    public static int[,] GenerateMatrix()
    {
        int[,] matrix = new int[4, 4];
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            List<int> ints = Console.ReadLine()!
                .Split(' ')
                .Select(int.Parse)
                .Take(4)
                .ToList();

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = ints[col];
            }
        }

        return matrix;
    }
    public static int[,] SubMatrix(int row, int col, int[,] matrix)
    {
        int[,] subMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
        int subCol = 0;
        int subRow = 0;

        for (int r = 0; r < matrix.GetLength(0); r++)
        {
            for (int c = 0; c < matrix.GetLength(1); c++)
            {
                if ((r != row) && (c != col))
                {
                    subMatrix[subRow, subCol] = matrix[r, c];

                    if (subCol < subMatrix.GetLength(0) - 1)
                    {
                        subCol++;
                    }
                    else
                    {
                        subRow++;
                        subCol = 0;
                    }
                }
            }
        }

        return subMatrix;
    }
    public static int Delta(int[,] matrix)
    {
        int det = 0;
        for (int i = 0; i < 3; i++)
        {
            det = det + (matrix[0, i] * matrix[1, (i + 1) % 3] * matrix[2, (i + 2) % 3]) - (matrix[0, i] * matrix[1, (i + 2) % 3] * matrix[2, (i + 1) % 3]);
        }
        return det;
    }
}