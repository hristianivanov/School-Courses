using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_or_Even_with_stack
{
    class Program
    {
        static Stack<int> ReversingStack(Stack<int> stack)
        {
            Stack<int> revers = new Stack<int>();
            while (stack.Count > 0)
            {
                revers.Push(stack.Pop());
            }
            return revers;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the amount of numbers: ");
            int n = int.Parse(Console.ReadLine());

            Random randNum = new Random();

            int[] numbers= Enumerable
            .Repeat(0,n)
            .Select(i => randNum.Next(1, 100))
            .ToArray();

            Console.Write("The random numbers : ");
            Console.WriteLine(string.Join(" ", numbers));

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                stack.Push(numbers[i]);
            }

            Stack<int> even = new Stack<int>(); // chetno
            Stack<int> odd = new Stack<int>(); // nechetno

            while (stack.Count > 0)
            {

                if (stack.Peek() % 2==0)
                {
                    even.Push(stack.Pop() );
                }
                else
                {
                    odd.Push(stack.Pop() );
                }

            }

            Console.Write("The even numbers: ");
            Console.WriteLine(string.Join(" ",ReversingStack(even) ));

            Console.Write("The odd numbers: ");
            Console.WriteLine(string.Join(" ",odd));
          
        }
    }
}
