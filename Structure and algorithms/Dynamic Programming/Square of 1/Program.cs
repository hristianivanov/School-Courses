namespace Square_of_1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[,] matrix =
			{
				{0,1,0,1,1},
				{0,0,0,1,1},
				{0,0,1,1,1},
				{1,0,1,1,1},
				{0,0,1,1,1},
			};

			int result = SquareOfOne(matrix);

			Console.WriteLine(result);
		}
		static int SquareOfOne(int[,] matrix)
		{
			int max = 0;

			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					if (matrix[i, j] == 1 && i == 0)
						max++;

					else if (matrix[i, j] == 1 && i >= 1 && j >= 1)
					{
						matrix[i, j] = GetMin(matrix[i - 1, j], matrix[i - 1, j - 1], matrix[i, j - 1]) + 1;
						max = matrix[i, j];
					}
				}
			}

			PrintMatrix(matrix);

			return max * max;
		}

		static int GetMin(int a, int b, int c) => Math.Min(a, Math.Min(b, c));


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