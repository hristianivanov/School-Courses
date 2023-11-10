namespace Third_problem
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] nums =
				{ 1, 2, 3, 8, 9, 10, 23, 24, 25, 26, };

			var result = BinarySearch(nums, 27, 0, nums.Length - 1);

            Console.WriteLine(result);
        }

		private static int BinarySearch(int[] arr, int num, int left, int right)
		{
			if (left <= right)
			{
				int mid = (left + right) / 2;

				if (arr[mid] == num)
					return arr[mid];

				if (arr[mid] < num)
					return BinarySearch(arr, num, mid + 1, right);
				else
					return BinarySearch(arr, num, left, mid);
			}

			return -1;
		}

	}
}