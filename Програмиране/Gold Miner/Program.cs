using System;
using System.Linq;
using System.Collections.Generic;

namespace Gold_Miner
{
    class Program
    {
        static void Main(string[] args)
        {

            var dict = new Dictionary<string, int>();

            while (true)
            {
                string material = Console.ReadLine();

                if (material != "stop")
                {
                    break;
                }

                int quantity = int.Parse(Console.ReadLine());

                if (dict.ContainsKey(material))
                {
                    dict[material] += quantity;
                }
                else
                {
                    dict.Add(material, quantity);
                }


            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}