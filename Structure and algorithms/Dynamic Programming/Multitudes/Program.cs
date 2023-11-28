namespace Multitudes
{
	internal class Program
	{
		//Two partition problem with multitudes
		//sum(a) = sum( u / a)
		static void Main(string[] args)
		{
			int[] set = { 1, 3, 4, 13, 5 };
			int sum = set.Sum();
			if (sum % 2 == 1 || set.Any(x => x > sum / 2))
			{
				Console.WriteLine(false);
				return;
			}

			bool[,] matrix = new bool[set.Length, sum / 2];
			matrix[0, 0] = true;
			for (int i = 1; i < matrix.GetLength(0); i++)
			{
				matrix[0, i] = i == set[0];
				//if(i == set[0])
				//{
				//    matrix[0, i] = true;
				//}
				//matrix[0, i] = false;
			}
			for (int i = 1; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					matrix[i, j] = matrix[i - 1, j];
					if (j - set[i] >= 0)
					{
						matrix[i, j] = matrix[i - 1, j] || matrix[i - 1, j - set[i]];
					}
				}
			}
			Console.WriteLine(matrix[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1]);
		}
	}
}