namespace _00.Demo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] array = { 3, 9, 1, 2 };

			Tuple<int, int>[,] matrix = new Tuple<int, int>[array.Length, array.Length];


			for (int i = 0; i < array.Length; i++)
			{
				for (int col = i; col < array.Length; col++)
				{
					for (int row = 0; row < col; row++)
					{
						if (row == col)
						{
							matrix[row, col] = new Tuple<int, int>(array[row], 0);
						}

						if (col % 2 != 0)
						{
							matrix[row, col] = new Tuple<int, int>(matrix[row - 1, col].Item1, matrix[row, col - 1].Item1);
						}
						else
						{

						}

					}

				}
			}

		}
	}
}