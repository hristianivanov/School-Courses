using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        static decimal Factorial(int n)
        {
            // The bottom of the recursion
            if (n == 0)
            {
                return 1;
            }
            // Recursive call: the method calls itself
            return n * Factorial(n - 1);
        }
        public static int Degree(int x, int n)
        {
            int output;
            if (n == 0)
            {
                return 1;
            }
            if (n % 2 == 0)
            {
                output = Degree(x, n / 2);
                return output * output;
            }
            else
            {
                return x * Degree(x, n - 1);
            }
        }

        public static string Binary(int num)
        {
            if (num == 1)
            {
                return "1";
            }
            else
            {
                return Binary(num / 2) + Convert.ToString(num % 2);
            }
        }


        public static long GreatestCommonDivisor(long a, long b)
        {
            if (b == 0)
            {
                return a;
            }
            else
            {
                return GreatestCommonDivisor(b, a % b);
            }
        }
        static string DecimalToHex(int value)
        {

            string hexnums = "0123456789ABCDEF";

            string result = "";

            if (value <= 0)
            {
                result = "";
            }
            else
            {
                result = DecimalToHex(value / 16) + hexnums[value % 16];
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;







        }
    }
}
