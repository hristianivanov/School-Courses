namespace GreatestCommonDiviser
{
	internal class Program
	{
		public static long GreatestCommonDivisor(long a, long b)
		{
			if (b == 0)
				return a;

			return GreatestCommonDivisor(b, a % b);
		}
		static void Main(string[] args)
		{
			Console.WriteLine(GreatestCommonDivisor(5, 15));
		}
	}
}