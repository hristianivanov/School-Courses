namespace Natural_numbers
{
	internal class Program
	{
		private static int SumNaturalNumbers(int n)
		{
			if (n == 0)
			{
				return 0;
			}

			return n + SumNaturalNumbers(n - 1);
		}

		static void Main(string[] args)
		{
			
		}
	}
}