namespace Quick_sort
{
	internal class Program
	{
		private static void Swap(int[] nums, int i, int j)
		{
			int temp = nums[i]; 
			nums[i] = nums[j];
			nums[j] = temp;
		}

		private static void QuickSort(int[] nums, int left, int right)
		{
			if (left < right)
			{
				int pivotPoss = Partition(nums, left, right);

				QuickSort(nums, pivotPoss + 1, right);
				QuickSort(nums, left, pivotPoss - 1);
			}
		}

		private static int Partition(int[] nums, int left, int right)
		{
			int pivot = nums[right];

			int i  = left;

			for (int j = left; j < right; j++)
			{
				if (nums[j] < pivot)
				{
					int temp = nums[i];
					nums[i] = nums[j];
					nums[j] = temp;
					i++;
				}
			}

			int swap = nums[i];
			nums[i] = pivot;
			nums[right] = swap;

			return i;
		}

		static void Main(string[] args)
		{
			int[] nums = new int[]
			{
				5,3,2
			};

			QuickSort(nums, 0, nums.Length - 1);

			for (int i = 0; i < nums.Length; i++)
			{
				Console.Write(nums[i] + ", ");
            }
		}
	}
}