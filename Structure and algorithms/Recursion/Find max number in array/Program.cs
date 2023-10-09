namespace Find_max_number_in_array
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] nums =
				{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 54, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26 };

            Console.WriteLine(MaxNumber(nums));
        }

		private static int MaxNumber(int[] array)
		{
			if (array.Length == 0)
				throw new InvalidOperationException("The given array is empty!");

			if (array.Length == 1)
				return array[0];

			int restMax = MaxNumber(
				array
					.Skip(1)
					.ToArray()
				);

			return array[0] > restMax ? array[0] : restMax;
		}
	}
}