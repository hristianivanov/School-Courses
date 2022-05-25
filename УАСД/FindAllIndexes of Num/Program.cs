using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAllIndexes_of_Num
{
    class Program
    {
        static List<int> FindAllIndexes(int[] numbers,int number)
        {
      
            List<int> list = new List<int>();
            for (int index = 0; index < numbers.Length; index++)
            {
                if (number==numbers[index])
                {
                    list.Add(index);
                }
            }
            return list;
        }
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int num = int.Parse(Console.ReadLine()); 
            List<int> indexes = FindAllIndexes(numbers, num);
            Console.WriteLine(string.Join(",",indexes));
        }
    }
}
