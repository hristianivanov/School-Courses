namespace Second_problem
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int n = 6;

			DrawFigure(n);
		}

		static void DrawStars(int n)
		{
			if (n <= 0)
				return;

			DrawStars(n - 1);
			Console.WriteLine(new string('*', n));
		}

		static void DrawHashes(int n)
		{
			if (n <= 0)
				return;

			Console.WriteLine(new string('#', n));
			DrawHashes(n - 1);
		}

		static void DrawFigure(int n)
		{
			DrawStars(n);
			DrawHashes(n);
		}
	}
}