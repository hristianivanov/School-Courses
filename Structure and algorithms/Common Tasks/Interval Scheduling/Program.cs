namespace Interval_Scheduling
{
    internal class Program
    {
        static void Main(string[] args)
        {
			Tuple<int, int>[] intervals = new Tuple<int, int>[]
			{
				new Tuple<int, int>(1, 3),
				new Tuple<int, int>(1, 2),
				new Tuple<int, int>(1, 5),
				new Tuple<int, int>(1, 5),
				new Tuple<int, int>(2, 3),
				new Tuple<int, int>(3, 6),
				new Tuple<int, int>(4, 5),
				new Tuple<int, int>(4, 6),
				new Tuple<int, int>(5, 6),
			};

			List<Tuple<int, int>> selectedIntervals = ScheduleIntervals(intervals);

			Console.WriteLine("Selected Intervals:");
			foreach (var interval in selectedIntervals)
			{
				Console.WriteLine($"({interval.Item1}, {interval.Item2})");
			}
		}

        static List<Tuple<int, int>> ScheduleIntervals(Tuple<int, int>[] intervals)
        {
	        List<Tuple<int, int>> selectedIntervals = new List<Tuple<int, int>>();

	        intervals = intervals
		        .OrderBy(i => i.Item2)
		        .ToArray();

	        Tuple<int, int> currInterval = intervals[0];

	        selectedIntervals.Add(currInterval);

	        for (int i = 1; i < intervals.Length; i++)
	        {
		        Tuple<int, int> nextInterval = intervals[i];

		        if (nextInterval.Item1 >= currInterval.Item2)
		        {
			        selectedIntervals.Add(nextInterval);
			        currInterval = nextInterval;
		        }
	        }

	        return selectedIntervals;
        }
	}
}