namespace Majorant_Task
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] nums = new int[] { 2, 2, 3, 3, 2, 3, 4, 3, 3 };
			int count = nums.Length;

			Dictionary<int, int> kvp = new Dictionary<int, int>();
			int majorant = 0;
			foreach (int num in nums)
			{
				if (kvp.ContainsKey(num))
					kvp[num]++;
				else 
					kvp.Add(num, 1);

				if (kvp[num] > count / 2)
					majorant = num;
			}

			if (majorant != 0)
				Console.WriteLine($"Yes -> {majorant}");
			else
				Console.WriteLine("No");
		}
	}
}