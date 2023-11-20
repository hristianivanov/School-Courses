namespace Queue
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<int> times = Console.ReadLine()!
				.Split(" ")
				.Select(int.Parse)
				.ToList();

			List<int> combination = Console.ReadLine()!
				.Split(" ")
				.Select(int.Parse)
				.ToList();

			int[] optimalValues = new int[times.Count];
			optimalValues[0] = times[0];
			optimalValues[1] = Math.Min(combination[0], times[0] + times[1]);

			for (int i = 2; i < times.Count; i++)
			{
				optimalValues[i] = Math.Min(combination[i - 1], times[i - 2] + times[i]);
			}

			Console.WriteLine("The solution is: " + optimalValues[times.Count - 1]);
		}
	}
}