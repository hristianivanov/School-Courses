namespace Pascal_triangle
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int numRows = 6;
			var triangle = GeneratePascalTriangle(numRows);

			Console.WriteLine(string.Join(" ", triangle[numRows - 1]));
		}

		static int[][] GeneratePascalTriangle(int rows)
		{
			int[][] triangle = new int[rows][];

			for (int i = 0; i < rows; i++)
			{
				triangle[i] = new int[i + 1];
				triangle[i][0] = 1;

				for (int j = 1; j < i; j++)
				{
					triangle[i][j] = triangle[i - 1][j - 1] + triangle[i - 1][j];
				}

				triangle[i][i] = 1;
			}

			return triangle;
		}
	}
}