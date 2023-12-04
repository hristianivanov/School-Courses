namespace Pedestrian_matrix_problem
{
	internal class Program
	{
		public int Traverse(int row, int col)
		{
			if (row == 0 && col == 0)
				return 1;

			int sum = 0;

			sum += Traverse(row - 1, col);
			sum += Traverse(row, col - 1);

			return sum;
		}
		static void Main(string[] args)
		{
			int n = 3;

			int[,] a =
			{
				{5,1,1 },
				{7,2,2 },
				{1,1,2 },
				{2,1,3 }
			};
			int[,] b =
			{
				{6,5,1,1 },
				{1,2,2,1 },
				{1,1,1,1 }
			};

			int[,] opt = new int[n + 1, n + 1];

			opt[0, 0] = 0;

			for (int r = 1; r <= n; r++)
			{
				opt[0, r] = opt[0, r - 1] + a[0, r - 1];
			}
			for (int c = 1; c <= n; c++)
			{
				opt[c, 0] = opt[c - 1, 0] + b[c - 1, 0];
			}

			for (int i = 1; i <= n; i++)
			{
				for (int j = 1; j <= n; j++)
				{
					opt[i, j] = Math.Min(opt[i, j - 1] + a[i, j - 1], opt[i - 1, j] + b[i - 1, j]);
				}
			}

			Console.WriteLine(opt[opt.GetLength(0) - 1, opt.GetLength(1) - 1]);
		}
	}
}