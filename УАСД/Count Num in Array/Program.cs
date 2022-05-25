using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Num_in_Array
{
    class Program
    {
        static void Counter(int[] numbers)
        {
            int count = 0;
            int[] arr = numbers.Distinct().ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (arr[i] == numbers[j])
                    {
                        count++;
                    }

                }
                Console.WriteLine($"{arr[i]} -> {count}");
                count = 0;
            }
        }
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Counter(num);
        }
    }
}
