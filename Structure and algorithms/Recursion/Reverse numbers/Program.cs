namespace Reverse_numbers
{
	internal class Program
	{
		private static int ReverseNum(int num)
		{
			if (num < 10)
			{
				return num;
			}

			int lastDigit = num % 10;
			int remainingNum = num / 10;
			int reversedRemaining = ReverseNum(remainingNum);

			int reversedNum = Concatenate(lastDigit, reversedRemaining);

			return reversedNum;
		}

		private static int Concatenate(int a, int b)
		{
			int result = a;
			while (b > 0)
			{
				result = result * 10 + (b % 10);
				b /= 10;
			}
			return result;
		}

		static void Main(string[] args)
		{
            Console.WriteLine(ReverseNum(123));
        }
	}
}