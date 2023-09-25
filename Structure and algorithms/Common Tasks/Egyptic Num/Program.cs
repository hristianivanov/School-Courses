namespace Egyptic_Num
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numerator = 7;
            int denominator = 9;


            while (numerator != 0)
            {
                int ceil = (int)Math.Ceiling((double)denominator / numerator);
                Console.WriteLine($"1/{ceil}");

                numerator = numerator * ceil - denominator;
                denominator *= ceil;
            }
        }
    }
}