namespace Demo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int n = 6;

			DrawStars(n);
		}

		static void DrawStars(int n)
		{
			if (n <= 0)
				return;
			DrawStars(n - 1);
			Console.WriteLine(new string('*', n));
		}
	}
}