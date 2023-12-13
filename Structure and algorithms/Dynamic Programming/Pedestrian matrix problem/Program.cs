namespace Pedestrian_matrix_problem
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var matrix = new int[4, 4];

			Console.WriteLine(TraverseDynamic(3, 3, matrix));
		}

		static int TraverseRecursive(int row, int col)
		{
			if (row == 0 || col == 0)
				return 1;

			int sum = 0;
			sum += TraverseRecursive(row - 1, col);
			sum += TraverseRecursive(row, col - 1);

			return sum;
		}
		static int TraverseDynamic(int row, int col, int[,] matrix)
		{
			if (row == 0 || col == 0)
			{
				return 1;
			}

			if (matrix[row - 1, col] != 0 && matrix[row, col - 1] == 0)
			{
				matrix[row, col] = matrix[row - 1, col] + TraverseRecursive(row - 1, col);
			}
			else if (matrix[row - 1, col] == 0 && matrix[row, col - 1] != 0)
			{
				matrix[row, col] = matrix[row, col - 1] + TraverseRecursive(row - 1, col);
			}
			else if (matrix[row - 1, col] != 0 && matrix[row, col - 1] != 0)
			{
				matrix[row, col] = matrix[row - 1, col] + matrix[row, col - 1];
			}
			else
			{
				matrix[row, col] += TraverseRecursive(row - 1, col);
				matrix[row, col] += TraverseRecursive(row, col - 1);
			}

			return matrix[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
		}
	}
}