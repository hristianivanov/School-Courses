namespace Factoriel
{
	internal class Program
	{
		private static int Factoriel(int n)
		{
			if (n == 0)
				return 1;

			return Factoriel(n - 1) * n;
		}

		static void Main(string[] args)
		{
			
		}
	}
}