namespace Multitudes
{
	internal class Program
	{
		//sum(a) = sum( u / a)
		static void Main(string[] args)
		{
			var nums = new int[] { 1, 3, 4, 1, 3, 5 };

			var sum = nums.Sum();

			bool isValid = sum % 2 == 0 &&
						   nums.Any(n => n <= sum); // ? = 

			if (isValid)
			{

			}
		}
	}
}