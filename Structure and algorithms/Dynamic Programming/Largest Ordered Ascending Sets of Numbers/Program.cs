namespace Largest_Ordered_Ascending_Sets_of_Numbers
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region 1

			var nums = new int[] { -5, 0, -2, -10, 1, 15, 25 };

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

			#endregion

			#region 2

			int[] numbers = { -5, 0, -2, 10, 1, 15, 25 };
			int result = LongestAscendingSubsequence(numbers);
			Console.WriteLine(result);

			#endregion
		}
		static int LongestAscendingSubsequence(int[] nums)
		{
			int n = nums.Length;
			int[] lis = new int[n];

			for (int i = 0; i < n; i++)
			{
				lis[i] = 1;
				for (int j = 0; j < i; j++)
				{
					if (nums[i] > nums[j] && lis[i] < lis[j] + 1)
					{
						lis[i] = lis[j] + 1;
					}
				}
			}

			return lis.Max();
		}
	}
}