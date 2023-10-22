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
				{ ' ', ' ', ' ', ' ', ' ', ' ', 'e' }
			};
		}


		static void FindPath(char[,] arr, int row,int col)
		{
			if (!IsVailid(row,col,arr))
			{
				return;
			}

			if (arr[row,col] == 'e')
			{
				Console.WriteLine("Found path");
				return;
			}


		}

		private static bool IsVailid(int row, int col, char[,] arr)
			=> row < arr.GetLength(0) && row >= 0
		&& col < arr.GetLength(1) && col >= 0;
	}
}