namespace _0.Demo
{
	internal class Program
	{
		const int BoardSize = 8;
		static int countOfSolutions = 0;
		static List<int> attackedRows = new List<int>();
		static List<int> attackedCols = new List<int>();
		static List<int> attackedRightDiagonals = new List<int>();
		static List<int> attackedLeftDiagonals = new List<int>();

		static void Main(string[] args)
		{
			bool[,] board = new bool[BoardSize, BoardSize];
			SolveQueensPuzzle(0, board);
			Console.WriteLine(countOfSolutions);
		}

		static bool CanPlaceQueen(int row, int col)
		{
			bool result = attackedRows.Contains(row) ||
						  attackedCols.Contains(col) ||
						  attackedRightDiagonals.Contains(col - row) ||
						  attackedLeftDiagonals.Contains(row + col);

			return !result;
		}

		static void SolveQueensPuzzle(int row, bool[,] board)
		{
			if (row == BoardSize)
			{
				countOfSolutions++;
				for (int i = 0; i < board.GetLength(0); i++)
				{
					for (int j = 0; j < board.GetLength(1); j++)
					{
						if (board[i, j])
							Console.Write('*');
						else
							Console.Write('-');
					}
					Console.WriteLine();
				}
			}
			else
			{
				for (int col = 0; col < BoardSize; col++)
				{
					if (CanPlaceQueen(row, col))
					{
						//Add Queen to all the collections
						attackedRows.Add(row);
						attackedCols.Add(col);
						attackedRightDiagonals.Add(col - row);
						attackedLeftDiagonals.Add(col + row);
						board[row, col] = true;

						SolveQueensPuzzle(row + 1, board);
						//Remove Queen from all the collections
						attackedRows.Remove(row);
						attackedCols.Remove(col);
						attackedRightDiagonals.Remove(col - row);
						attackedLeftDiagonals.Remove(col + row);
						board[row, col] = false;
					}
				}
			}
		}



		static void permute(int[] arr, int left, int right)
		{
			if (left == right)
			{
				for (int i = 0; i < right; i++)
				{
					Console.Write(arr[i] + " ");
				}
				Console.WriteLine();
				return;
			}



			for (int i = left; i < right; i++)
			{
				// swap(arr[left] , arr[i])
				int temp = arr[left];
				arr[left] = arr[i];
				arr[i] = temp;



				permute(arr, left + 1, right);
				// swap(arr[left] , arr[i])
				temp = arr[left];
				arr[left] = arr[i];
				arr[i] = temp;
			}
		}
	}
}