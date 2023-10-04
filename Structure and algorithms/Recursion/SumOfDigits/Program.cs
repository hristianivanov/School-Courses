namespace SumOfDigits
{
	internal class Program
	{
		static void Main(string[] args)
		{
            Console.WriteLine(MultiplyOfDigits(23));
        }

		// *
		private static int MultiplyOfDigits(int n)
		{
			if (n < 10)
			{
				return n;
			}

			int lastDigit = n % 10;
			int remainingDigits = n / 10;
			int sum = lastDigit * MultiplyOfDigits(remainingDigits);

			return sum;
		}

		// +
		private static int SumOfDigits(int n)
		{
			if (n < 10)
			{
				return n;
			}

			int lastDigit = n % 10;
			int remainingDigits = n / 10;
			int sum = lastDigit + SumOfDigits(remainingDigits);

			return sum;
		}
	}
}