using System;
using System.Linq;
using System.Collections.Generic;

namespace Phone_Service
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToList();

            var dict = new Dictionary<string, int>();

            while (input[0].ToString().ToUpper() != "END")
            {
                if (input[0] == "A")
                {
                    if (dict.ContainsKey(input[1]))
                    {
                        dict[input[1]] = int.Parse(input[2]);
                    }
                    else
                    {
                        dict.Add(input[1], int.Parse(input[2]));
                    }
                }
                else if (input[0] == "S")
                {
                    if (dict.ContainsKey(input[1]))
                    {
                        Console.WriteLine($"{input[1]} -> {dict[input[1]]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {input[1]} does not exist.");
                    }
                }

                input = Console.ReadLine().Split().ToList();
            }
        }
    }
}