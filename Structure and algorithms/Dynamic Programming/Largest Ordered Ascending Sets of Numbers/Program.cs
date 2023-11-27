namespace Largest_Ordered_Ascending_Sets_of_Numbers
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var nums = new int[] { -5, 0, -2, -10, 1, 15, 25, 6 };

			var sets = new int[nums.Length];

			for (int i = 0; i < sets.Length; i++)
				sets[i] = 1;

			for (int i = 1; i < nums.Length; i++)
			{
				for (int j = 0; j < i; j++)
				{
					if (nums[j] < nums[i] && sets[j] + 1 > sets[i])
						sets[i] = sets[j] + 1;
				}
			}

			Console.WriteLine(sets.Max());
		}

		private static void SolveProblemWithStoringTheNumbers()
		{
			var nums = new int[] { -5, 0, -2, -10, 1, 15, 25, 6 };

			var sets = new List<List<int>> { new List<int> { nums[0] } };

			for (int i = 1; i < nums.Length; i++)
			{
				var currentSet = new List<int> { nums[i] };

				for (int j = 0; j < i; j++)
				{
					if (nums[j] < nums[i] && sets[j].Count + 1 > currentSet.Count)
					{
						currentSet.Clear();
						currentSet.AddRange(sets[j]);
						currentSet.Add(nums[i]);
					}
				}

				sets.Add(new List<int>(currentSet));
			}

			var largestSet = sets.OrderByDescending(set => set.Count).First();

			Console.WriteLine($"Length of the largest ordered ascending set: {largestSet.Count}");
			Console.WriteLine("Numbers in the largest ordered ascending set: " + string.Join(", ", largestSet));
		}
	}
}