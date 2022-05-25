using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitals
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder input = new StringBuilder(Console.ReadLine() );
            List<char> list = new List<char>();
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsUpper(input[i]) )
                {
                    list.Add(input[i]);
                }
            }
            foreach (var item in list)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
