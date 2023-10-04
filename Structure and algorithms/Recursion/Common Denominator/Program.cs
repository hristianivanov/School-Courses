namespace Common_Denominator
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int num1 = 4;
			int num2 = 5;

			int lcm = FindLCM(num1, num2);

			Console.WriteLine(lcm);
		}
		private static int FindLCM(int a, int b)
		{
			return (a * b) / FindGCD(a, b);
		}

		private static int FindGCD(int a, int b)
		{
			if (b == 0)
				return a;

			return FindGCD(b, a % b);
		}
	}
}