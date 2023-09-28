using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
	static int FindMajorant(List<int> arr)
	{
		Dictionary<int, int> counts = new Dictionary<int, int>();
		int n = arr.Count;

		foreach (int num in arr)
		{
			if (counts.ContainsKey(num))
			{
				counts[num]++;
			}
			else
			{
				counts[num] = 1;
			}

			if (counts[num] > n / 2)
			{
				return num;
			}
		}

		return -1;  // No majorant
	}

	static void Main()
	{
		List<int> arr = new List<int> { 2, 2, 3, 3, 2, 3, 4, 3, 3 };
		int majorant = FindMajorant(arr);

		if (majorant != -1)
		{
			Console.WriteLine("The majorant is: " + majorant);
		}
		else
		{
			Console.WriteLine("The majorant does not exist!");
		}
	}
}
