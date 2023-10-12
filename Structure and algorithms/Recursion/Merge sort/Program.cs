namespace Merge_sort
{
	internal class Program
	{
		public static void MergeSort(int[] array, int left, int right)
		{
			if (left < right)
			{
				int middle = left + (right - left) / 2;

				MergeSort(array, left, middle);
				MergeSort(array, middle + 1, right);

				MergeArray(array, left, middle, right);
			}
		}

		public static void MergeArray(int[] array, int left, int middle, int right)
		{
			var leftArrayLength = middle - left + 1;
			var rightArrayLength = right - middle;
			var leftTempArray = new int[leftArrayLength];
			var rightTempArray = new int[rightArrayLength];
			int i, j;

			for (i = 0; i < leftArrayLength; ++i)
				leftTempArray[i] = array[left + i];
			for (j = 0; j < rightArrayLength; ++j)
				rightTempArray[j] = array[middle + 1 + j];

			i = 0; j = 0;
			int k = left;

			while (i < leftArrayLength && j < rightArrayLength)
			{
				if (leftTempArray[i] <= rightTempArray[j])
					array[k++] = leftTempArray[i++];
				else
					array[k++] = rightTempArray[j++];
			}

			while (i < leftArrayLength)
				array[k++] = leftTempArray[i++];

			while (j < rightArrayLength)
				array[k++] = rightTempArray[j++];
		}


		static void Main(string[] args)
		{
			int[] nums = new int[]
			{
				5,3,2,-3,53,-532,3632
			};

			MergeSort(nums, 0, nums.Length - 1);

			for (int i = 0; i < nums.Length; i++)
			{
				Console.Write(nums[i] + ", ");
			}
		}
	}
}