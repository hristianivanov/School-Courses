namespace Reverse_string
{
	internal class Program
	{
		private static string ReverseString(string value)
		{
			if (string.IsNullOrEmpty(value) 
			    || value.Length == 1)
			{
				return value;
			}

			string reversedSubString = ReverseString(value.Substring(1));

			string reversedString = reversedSubString + value[0];

			return reversedString;
		}
		static void Main(string[] args)
		{
            Console.WriteLine(ReverseString("123"));
        }
	}
}