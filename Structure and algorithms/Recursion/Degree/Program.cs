namespace Degree
{
	internal class Program
	{
		public static int Degree(int num, int degree)
		{
			if (degree == 0)
				return 1;

			return num * Degree(num, degree - 1);
		}
		static void Main(string[] args)
		{
			Console.WriteLine(Degree(2,6));
		}
	}
}