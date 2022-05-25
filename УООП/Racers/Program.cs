using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                List<string> input = Console.ReadLine().
                    Split(' ').
                    ToList();
                try
                {
                    Participants participant = new Participants( input[0],
                        int.Parse(input[1]),
                        int.Parse(input[2]),
                        int.Parse(input[3]) ) ;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
