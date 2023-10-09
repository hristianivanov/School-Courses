namespace IsWordPalindrome
{
	internal class Program
	{
		static void Main(string[] args)
		{
            Console.WriteLine(IsPalindrome("abcba"));
        }

		private static bool IsPalindrome(string word)
		{
			if (word.Length <= 1)
				return true;

			if (word[0] != word[word.Length - 1])
				return false;

			return IsPalindrome(word.Substring(1, word.Length - 2));
		}
	}
}