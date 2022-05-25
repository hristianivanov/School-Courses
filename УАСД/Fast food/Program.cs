using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fast_food
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<int> queue = new Queue<int>();
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < input.Length; i++)
            {
                queue.Enqueue(input[i]);
            }


            int max = int.MinValue;
            for (int i = 0; i < input.Length; i++)
            {
                if (max<input[i])
                {
                    max = input[i];
                }
            }
            Console.WriteLine(max);

            queue.Reverse();
            
            while ()
            {

            }
            


        }
    }
}
