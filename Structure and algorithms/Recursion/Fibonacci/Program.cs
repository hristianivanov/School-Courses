namespace Fibonacci
{
	internal class Program
	{
		private static int Fibonacci(int n)
		{
			if (n == 0 || n == 1) 
				return 1;

			return Fibonacci(n - 1) + Fibonacci(n - 2);
		}

		static void Main(string[] args)
		{

		}
	}
}