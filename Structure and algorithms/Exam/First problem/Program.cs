namespace First_problem
{
	internal class Program
	{
		// price per one task
		const int price = 100;
		static void Main(string[] args)
		{
			// start time - end time
			Tuple<int, int>[] intervals = new Tuple<int, int>[]
			{
				new Tuple<int, int>(1, 3),
				new Tuple<int, int>(1, 2),
				new Tuple<int, int>(2, 7),
				new Tuple<int, int>(3, 5),
				new Tuple<int, int>(4, 5),
				new Tuple<int, int>(5, 8),
				new Tuple<int, int>(5, 8),
			};

			int intervalsCnt = ScheduleIntervalsCount(intervals);

            Console.WriteLine(intervalsCnt * price);
        }

		static int ScheduleIntervalsCount(Tuple<int, int>[] intervals)
		{
			intervals = intervals
				.OrderBy(i => i.Item2)
				.ToArray();

			int cnt = 1;
			var currInterval = intervals[0];

			for (int i = 1; i <= intervals.Length - 1; i++)
			{
				var nextInterval = intervals[i];

				if (nextInterval.Item1 >= currInterval.Item2)
				{
					cnt++;
					currInterval = nextInterval;
				}
			}

			return cnt;
		}
	}
}