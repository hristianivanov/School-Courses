using System.ComponentModel;
using System.ComponentModel.Design;

namespace FindOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string test = "1+2-2*10/5";
            Console.WriteLine(StringMathExpressionConverter(test));
            
            int n = int.Parse(Console.ReadLine());
            string[] nums = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            int sum = int.Parse(Console.ReadLine());
            
            //string test = string.Empty;
            while (int.Parse(test) != sum)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    
                }
            }
        }

        private static int StringMathExpressionConverter(string expression)
        {
            int[] nums = expression.Split(new char[] {'+','-','*','/'},StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            char[] operators = expression.Where(x => !char.IsDigit(x))
                .ToArray();
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (operators[i] == '+')
                    sum += nums[i];
                else if (operators[i] == '-')
                    sum -= nums[i];
                else if (operators[i] == '/')
                    sum /= nums[i];
                else if (operators[i] == '*')
                    sum *= nums[i];
                else
                    throw new InvalidOperationException();
            }

            return sum;
        }
    }
}