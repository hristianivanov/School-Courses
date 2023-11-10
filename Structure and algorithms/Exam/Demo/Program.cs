namespace Demo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// abcba -> True
			// bor -> False

			string input = "abcba";

			bool result = IsPalindrome(input);

			Console.WriteLine(result);
		}

		private static bool IsPalindrome(string word)
		{
			if (word.Length == 1) 
				return true;

			if (word[0] != word[word.Length - 1])
				return false;

			string remainingLetters = word.Substring(1, word.Length - 2);

			return IsPalindrome(remainingLetters);
		}
	}
}