using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appoint_Dismiss_workers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Stack<string> worker = new Stack<string>();
            do
            {
                if (input[0] == "Appoint")
                {
                    worker.Skip();
                }
            } while (input[0]!="END");
        }
    }
}
