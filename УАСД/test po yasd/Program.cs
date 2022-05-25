using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_po_yasd
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            Stack<int> stack = new Stack<int>();


            for (int i = 0; i < n; i++)
            {
                stack.Push(numbers[i]);
            }

            numbers.Clear();
            foreach (var item in stack)
            {
                numbers.Add(item);
            }



            List<int> halfList = new List<int>();
            for (int i = numbers.Count / 2; i < numbers.Count; i++)
            {
                halfList.Add(numbers[i]);
            }

            for (int i = 0; i < halfList.Count; i++)
            {
                halfList[i] *= halfList[i];
            }

            halfList.Reverse();
            foreach (var item in halfList)
            {
                Console.Write($"{ item } ");
            }
            
        }
    }
}
