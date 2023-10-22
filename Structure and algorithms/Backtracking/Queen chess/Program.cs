namespace Queen_chess
{
	internal class Program
	{
		static int size = 8;

		static void SolveQueensProblem()
		{
			int[] queens = new int[size];
			PlaceQueens(queens, 0);
		}

		static void PlaceQueens(int[] queens, int row)
		{
			if (row == size)
			{
				PrintQueens(queens);
				return;
			}

			for (int col = 0; col < size; col++)
			{
				if (IsSafe(queens, row, col))
				{
					queens[row] = col;
					PlaceQueens(queens, row + 1);
				}
			}
		}

		static bool IsSafe(int[] queens, int row, int col)
		{
			for (int i = 0; i < row; i++)
			{
				if (queens[i] == col ||
					queens[i] - i == col - row ||
					queens[i] + i == col + row)
				{
					return false;
				}
			}

			return true;
		}

		static void PrintQueens(int[] queens)
		{
			Console.WriteLine("One possible arrangement:");
			for (int row = 0; row < size; row++)
			{
				for (int col = 0; col < size; col++)
				{
					if (queens[row] == col)
						Console.Write("Q ");
					else
						Console.Write(". ");
				}

				Console.WriteLine();
			}

			Console.WriteLine();
		}
		static void Main(string[] args)
		{
			SolveQueensProblem();
		}
	}
}