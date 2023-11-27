namespace Intervals_Scheduling
{
	internal class Program
	{
		static List<Tuple<int, int, int>> intervals = new List<Tuple<int, int, int>>();

		static void Main(string[] args)
		{
			intervals.Add(Tuple.Create(1, 3, 10));
			intervals.Add(Tuple.Create(2, 3, 5));
			intervals.Add(Tuple.Create(2, 5, 20));
			intervals.Add(Tuple.Create(4, 6, 15));
			intervals.Add(Tuple.Create(1, 2, 10));
			intervals.Add(Tuple.Create(5, 8, 35));
			intervals.Add(Tuple.Create(7, 8, 10));
			//intervals.Add(Tuple.Create(1, 8, 100));
			intervals.Add(Tuple.Create(2, 6, 30));

			intervals = intervals.OrderBy(x => x.Item2).ToList();
			int[] opt = new int[intervals.Count];
			opt[0] = Math.Max(0, intervals[0].Item3);

			for (int i = 1; i < intervals.Count; i++)
			{
				int valueWithoutCurrentInterval = opt[i - 1];
				int valueWithCurrentInterval = intervals[i].Item3;
				for (int j = i - 1; j >= 0; j--)
				{
					if (intervals[i].Item1 >= intervals[j].Item2)
					{
						valueWithCurrentInterval += opt[j];
						break;
					}
				}
				opt[i] = Math.Max(valueWithCurrentInterval, valueWithoutCurrentInterval);
			}

			Console.WriteLine(opt[intervals.Count - 1]);
		}
	}
}