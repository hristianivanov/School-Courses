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
					valueWithCurrentInterval += opt[j];
					break;
				}
				opt[i] = Math.Max(valueWithCurrentInterval, valueWithoutCurrentInterval);
			}

			Console.WriteLine(opt[intervals.Count - 1]);
		}

		#region other solution
		//static void Main(string[] args)
		//{
		//	var intervals = new List<Tuple<int, int, int>>()
		//	{
		//		Tuple.Create(1, 3, 10),
		//		Tuple.Create(2, 3, 5),
		//		Tuple.Create(2, 5, 20),
		//		Tuple.Create(4, 6, 15),
		//		Tuple.Create(1, 2, 10),
		//		Tuple.Create(5, 8, 35),
		//		Tuple.Create(7, 8, 10),
		//		Tuple.Create(2, 6, 30),
		//	};

		//	intervals = intervals.OrderBy(i => i.Item2).ToList();

		//	int result = MaxTotalValue(intervals);
		//	Console.WriteLine(result);
		//}

		static int MaxTotalValue(List<Tuple<int, int, int>> intervals)
		{
			int n = intervals.Count;
			int[] opt = new int[n];

			opt[0] = intervals[0].Item3;

			for (int i = 1; i < n; i++)
			{
				int currIntervalValueWithout = opt[i - 1];
				int currIntervalValueWith = intervals[i].Item3;

				int compatibleIntervalIndex = FindCompatibleInterval(intervals, i);

				if (compatibleIntervalIndex != -1)
					currIntervalValueWith += opt[compatibleIntervalIndex];

				opt[i] = Math.Max(currIntervalValueWith, currIntervalValueWithout);
			}

			return opt[n - 1];
		}

		static int FindCompatibleInterval(List<Tuple<int, int, int>> intervals, int currIndex)
		{
			for (int i = currIndex - 1; i >= 0; i--)
			{
				if (intervals[currIndex].Item1 >= intervals[i].Item2)
					return i;
			}
			return -1;
		}
		#endregion
	}
}