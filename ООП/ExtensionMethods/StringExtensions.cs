using System.Linq;

public static class StringExtensions
{
    public static string ReverseString(this string input)
    {
        return new string(input.Reverse().ToArray());
    }
}
