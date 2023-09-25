namespace Coin_Task
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] coinValues = { 200, 100, 50, 20, 10, 5, 2, 1 };

			decimal amount = decimal.Parse(Console.ReadLine()!);

			int totalAmountInStotinki = (int)(amount * 100);
			int totalCoinsUsed = 0;

			for (int i = 0; i < coinValues.Length; i++)
			{
				int coinCnt = totalAmountInStotinki / coinValues[i];
				totalCoinsUsed += coinCnt;
				totalAmountInStotinki %= coinValues[i];
			}

			Console.WriteLine(totalCoinsUsed);
		}
	}
}