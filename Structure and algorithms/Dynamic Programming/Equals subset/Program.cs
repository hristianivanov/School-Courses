namespace Equals_subset
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<int> mainSet = new List<int>() { 1, 3, 4, 13, 5 };
			bool result = CanBeDividedEqually(mainSet);
			Console.WriteLine(result);

			#region 2

			//List<int> mainSet = new List<int>() { 1, 3, 4, 13, 5 };

			//bool[,] subSet = new bool[mainSet.Count, mainSet.Sum() / 2];

			//bool result = false;

			//if (mainSet.Sum() % 2 == 1)
			//{
			//	result = false;
			//}

			//if (mainSet.Count == 1)
			//{
			//	result = false;
			//}


			//for (int i = 0; i <= mainSet.Count; i++)
			//{
			//	subSet[i, 0] = true;
			//	subSet[i, 1] = true;
			//}

			#endregion
		}

		static bool CanBeDividedEqually(List<int> set)
		{
			int totalSum = set.Sum();

			if (totalSum % 2 != 0 || set.Count < 2)
			{
				return false;
			}

			int targetSum = totalSum / 2;
			int n = set.Count;

			bool[,] matrix = new bool[targetSum + 1, n + 1];

			for (int i = 0; i <= n; i++)
			{
				matrix[0, i] = true;
			}

			for (int currentSum = 1; currentSum <= targetSum; currentSum++)
			{
				for (int currentElement = 1; currentElement <= n; currentElement++)
				{
					matrix[currentSum, currentElement] = matrix[currentSum, currentElement - 1];

					if (currentSum >= set[currentElement - 1])
					{
						matrix[currentSum, currentElement] = matrix[currentSum, currentElement] || matrix[currentSum - set[currentElement - 1], currentElement - 1];
					}
				}
			}

			return matrix[targetSum, n];
		}

		static bool isSubsetSum(int[] set, int n, int sum)
		{

			bool[,] subset = new bool[sum + 1, n + 1];


			for (int i = 0; i <= n; i++)
				subset[0, i] = true;


			for (int i = 1; i <= sum; i++)
				subset[i, 0] = false;


			for (int i = 1; i <= sum; i++)
			{
				for (int j = 1; j <= n; j++)
				{
					subset[i, j] = subset[i, j - 1];
					if (i >= set[j - 1])
					{
						subset[i, j] = subset[i, j] || subset[i - set[j - 1], j - 1];
					}
				}
			}

			return subset[sum, n];
		}
	}
}