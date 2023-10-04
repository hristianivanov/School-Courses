namespace BinarySearch
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] nums =
				{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, };

			Console.WriteLine(RecursiveBinarySearch(nums, 26, 0, nums.Length - 1));
		}

		private static int RecursiveBinarySearch(int[] array, int target, int left, int right)
		{
			if (left <= right)
			{
				int mid = (right + left) / 2;
				
				if (array[mid] == target)
					return array[mid];

				if (array[mid] < target)
					return RecursiveBinarySearch(array, target, mid + 1, right);

				return RecursiveBinarySearch(array, target, left, mid);
			}

			return -1;
		}
	}
}