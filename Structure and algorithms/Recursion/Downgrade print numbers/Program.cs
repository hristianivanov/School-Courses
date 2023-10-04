namespace Downgrade_print_numbers
{
	internal class Program
	{
		private static int DowngradeNum(int num)
		{
			if (num == 0)
				return 0;

			return int.Parse(num.ToString() + DowngradeNum(num - 1));
		}

		static void Main(string[] args)
		{
			Console.WriteLine(DowngradeNum(4));
		}
	}
}