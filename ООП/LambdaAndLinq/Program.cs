namespace LambdaAndLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Where(x => x > 50)
                .Sum()
                );

            Console.WriteLine(string.Join(", ",
                Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Where(x => x % 2 == 0)
                .OrderBy(x => x)
                .ToArray()
                ));

            List<int> nums = Console.ReadLine()
                 .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToList();
            Console.WriteLine(nums.Count(x => x % 2 == 0));
            Console.WriteLine(nums.Count(x => x % 2 != 0));

            string[] strings = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(string.Join(" ", strings.Where(x => char.IsUpper(x[0]))));

            Console.WriteLine(string.Join(Environment.NewLine,
                Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(decimal.Parse)
                .Select(x => (x * 1.2M).ToString("F2"))
                ));


            List<Person> people = ReadPeople();
            string condition = Console.ReadLine();
            int ageThreshold = int.Parse(Console.ReadLine());
            Func<Person, bool> filter = CreatePersonFilter(condition, ageThreshold);
            List<Person> matchingPeople = people.Where(filter).ToList();
            string formatString = Console.ReadLine();
            Action<Person> printPerson = CreatePersonPrinter(formatString);
            PrintPeople(matchingPeople, printPerson);
        }

        private static void PrintPeople(List<Person> people, Action<Person> printerPerson)
        {
            foreach (var person in people)
                printerPerson(person);
        }

        private static Action<Person> CreatePersonPrinter(string format)
        {
            if (format == "name age")
                return p => Console.WriteLine($"{p.Name} - {p.Age}");
            if (format == "name")
                return p => Console.WriteLine($"{p.Name}"); 
            if (format == "age")
                return p => Console.WriteLine($"{p.Age}");

            throw new ArgumentException("Invalid: " + format);
        }

        private static Func<Person, bool> CreatePersonFilter(string condition, int ageThreshold)
        {
            if (condition == "older")
                return p => p.Age >= ageThreshold;
            if (condition == "younger")
                return p => p.Age < ageThreshold;

            throw new ArgumentException($"Invalid filter: {condition} {ageThreshold}");
        }
        private static List<Person> ReadPeople()
        {
            int n = int.Parse(Console.ReadLine());

            List<Person> people = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(", ");
                string name = tokens[0];
                int age = int.Parse(tokens[1]);

                people.Add(new Person { Name = name, Age = age });
            }

            return people;
        }
        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
    }
}