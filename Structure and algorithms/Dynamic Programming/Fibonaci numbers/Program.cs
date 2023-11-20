namespace Fibonaci_numbers
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(Fib(2));
		}
		static int Fib(int n1, int n2, int counter)
		{
			if (counter == 0)
				return n2;

			else
				return Fib(n2, n2 + n1, counter - 1);
		}
		static int Fib(int n)
		{
			n = n - 2;
			return Fib(1, 1, n);
		}
	}
}