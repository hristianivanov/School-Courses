namespace Maze_matrix
{
	internal class Program
	{
		static void Main(string[] args)
		{
			char[,] lab =
			{
				{ ' ', ' ', ' ', '*', ' ', ' ', ' ' },
				{ '*', '*', ' ', '*', ' ', '*', ' ' },
				{ ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
				{ ' ', '*', '*', '*', '*', '*', ' ' },
				{ ' ', ' ', ' ', ' ', ' ', ' ', 'e' },
			};

			//List<string> paths = new List<string>();
			//paths.Add("S");

			FindPath(lab, 0, 0);
		}

		static void FindPath(char[,] arr, int row,int col)
		{
			if (!IsValid(row,col,arr))
			{
				return;
			}

			if (arr[row,col] == 'e')
			{
				Console.WriteLine("Found path");
				return;
			}

			if (arr[row, col] != ' ')
			{
				return;
			}

			arr[row, col] = 'x';
			
			FindPath(arr, row, col + 1);
			FindPath(arr, row + 1, col);
			FindPath(arr, row, col - 1);
			FindPath(arr, row - 1, col);

			arr[row, col] = ' ';
		}

		private static bool IsValid(int row, int col, char[,] arr)
			=> row < arr.GetLength(0) && row >= 0
		&& col < arr.GetLength(1) && col >= 0;

		static void FindPathOptimized(char[,] lab, int row, int col, string direction, List<string> paths)
		{
			if (col < 0 || row < 0 || 
			    row >= lab.GetLength(0) || 
			    col >= lab.GetLength(1))
			{
				return;
			}

			if (lab[row, col] == 'e')
			{
				paths.Add(direction);
				Console.WriteLine("Found a path!" + string.Join("", paths));
				return;
			}
			if (lab[row, col] != ' ')
			{
				return;
			}
			lab[row, col] = 'x';
			paths.Add(direction);

			FindPathOptimized(lab, row, col + 1, "R", paths);
			FindPathOptimized(lab, row + 1, col, "D", paths);
			FindPathOptimized(lab, row, col - 1, "L", paths);
			FindPathOptimized(lab, row - 1, col, "U", paths);

			lab[row, col] = ' ';
			paths.RemoveAt(paths.Count - 1);
		}

	}
}