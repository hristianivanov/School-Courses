namespace Reverse_array
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] nums =
				{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26 };

			ReverseArray(nums, 0, nums.Length - 1);

			Console.WriteLine(string.Join(" ", nums));
		}

		private static int[] ReverseArray(int[] nums, int leftIndex, int rightIndex)
		{
			int temp;

			if (leftIndex <= rightIndex)
			{
				temp = nums[leftIndex];
				nums[leftIndex] = nums[rightIndex];
				nums[rightIndex] = temp;

				ReverseArray(nums, leftIndex + 1, rightIndex - 1);
			}

			return nums;
		}
	}
}