using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<string> employees = new List<string> { "Alice", "Bob", "Charlie", "David", "Eve" };

        while (true)
        {
            Console.WriteLine("Select a criterion to modify the employee list:");
            Console.WriteLine("1. Name length");
            Console.WriteLine("2. Name starts with");
            Console.WriteLine("3. Name ends with");
            Console.WriteLine("0. Exit");

            int criterion = int.Parse(Console.ReadLine());

            if (criterion == 0)
                break;

            Console.WriteLine("Select an action to perform:");
            Console.WriteLine("1. Remove");
            Console.WriteLine("2. Duplicate");

            int action = int.Parse(Console.ReadLine());

            Predicate<string> predicate;
            switch (criterion)
            {
                case 1:
                    Console.Write("Enter the name length: ");
                    int length = int.Parse(Console.ReadLine());
                    predicate = name => name.Length == length;
                    break;
                case 2:
                    Console.Write("Enter the starting letter: ");
                    char letter = char.Parse(Console.ReadLine());
                    predicate = name => name.StartsWith(letter.ToString());
                    break;
                case 3:
                    Console.Write("Enter the ending substring: ");
                    string substring = Console.ReadLine();
                    predicate = name => name.EndsWith(substring);
                    break;
                default:
                    Console.WriteLine("Invalid criterion.");
                    continue;
            }

            if (action == 1)
            {
                employees.RemoveAll(predicate);
            }
            else if (action == 2)
            {
                List<string> duplicates = employees.FindAll(predicate);
                employees.AddRange(duplicates);
            }
            else
            {
                Console.WriteLine("Invalid action.");
                continue;
            }

            if (employees.Count == 0)
                Console.WriteLine("No one is still employed!");
            else
                Console.WriteLine(string.Join(", ", employees) + " are still employed!");
        }
    }
}
