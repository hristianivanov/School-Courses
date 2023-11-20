namespace Intervals_Scheduling
{
	using System.Reflection;

	internal class Program
	{
		static List<Tuple<int, int, int>> intervals = new List<Tuple<int, int, int>>()
		{
			new Tuple<int, int, int> (1, 3, 10),
			new Tuple<int, int, int> (2, 3, 5),
			new Tuple<int, int, int> (2, 5, 20),
			new Tuple<int, int, int> (4, 6, 15),
			new Tuple<int, int, int> (1, 2, 10),
			new Tuple<int, int, int> (5, 8, 35),
			new Tuple<int, int, int> (7, 8, 10),
			new Tuple<int, int, int> (1, 8, 100),
			new Tuple<int, int, int> (2, 6, 30),
		};

		static void Main(string[] args)
		{
			intervals = intervals
				.OrderBy(i => i.Item2)
				.ToList();

			int[] opt = new int[intervals.Count];
			opt[0] = intervals[0].Item3;

			for (int i = 1; i < intervals.Count; i++)
			{
				int value = opt[i - 1];
				int curr = intervals[i].Item3;

				for (int j = i - 1; j >= 0; j--)
				{
					if (intervals[i].Item1 >= intervals[i].Item2)
					{
						//value = 
					}
					
				}
			}
		}
	}
}