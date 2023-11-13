namespace Coin_problem
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] coins = new int[] { 1, 2, 5 };

			int sum = 5;

			int[,] matrix = new int[coins.Length + 1, sum + 1];


			for (int j = 1; j < matrix.GetLength(1); j++)
				matrix[0, j] = 0;

			for (int i = 0; i < matrix.GetLength(0); i++)
				matrix[i, 0] = 1;

			for (int i = 1; i < matrix.GetLength(0); i++)
			{
				for (int j = 1; j < matrix.GetLength(1); j++)
				{
					matrix[i, j] = matrix[i - 1, j];
					if (j >= coins[i - 1])
						matrix[i, j] += matrix[i, j - coins[i - 1]];
				}
			}

			int result = matrix[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];

			Console.WriteLine(result);

			PrintMatrix(matrix);
		}

		private static void PrintMatrix(int[,] matrix)
		{
			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					Console.Write(matrix[i, j] + " ");
				}

				Console.WriteLine();
			}
		}
	}
}