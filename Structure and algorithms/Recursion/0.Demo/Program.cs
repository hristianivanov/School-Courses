namespace _0.Demo
{
	internal class Program
	{
		static void Merge(int[] arr, int left, int mid, int right)
		{
			int n1 = mid - left + 1; // Include mid in the left subarray
			int n2 = right - mid;

			int[] L = new int[n1];
			int[] R = new int[n2];
			int i, j;

			// Copy data to temporary arrays L[] and R[]
			for (i = 0; i < n1; i++)
				L[i] = arr[left + i];
			for (j = 0; j < n2; j++)
				R[j] = arr[mid + 1 + j];

			i = 0; // Initial index of the first subarray
			j = 0; // Initial index of the second subarray

			int k = left; // Initial index of the merged subarray

			while (i < n1 && j < n2)
			{
				if (L[i] <= R[j])
				{
					arr[k] = L[i];
					i++;
				}
				else
				{
					arr[k] = R[j];
					j++;
				}
				k++;
			}

			// Copy the remaining elements of L[], if there are any
			while (i < n1)
			{
				arr[k] = L[i];
				i++; k++;
			}

			// Copy the remaining elements of R[], if there are any
			while (j < n2)
			{
				arr[k] = R[j];
				j++; k++;
			}
		}

		static void MergeSort(int[] arr, int left, int right)
		{
			if (left < right)
			{
				int mid = (left + right) / 2;

				// Sort first and second halves
				MergeSort(arr, left, mid);
				MergeSort(arr, mid + 1, right);

				// Merge the sorted halves
				Merge(arr, left, mid, right);
			}
		}


		static void Main(string[] args)
		{
			int[] nums = new int[]
			{
				5,3,2,5,4,347,3,76,534,37,3,2,3,0,-35
			};

			MergeSort(nums, 0, nums.Length - 1);

			for (int i = 0; i < nums.Length; i++)
			{
				Console.Write(nums[i] + ", ");
			}
		}
	}
}