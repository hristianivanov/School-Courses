namespace ExtensionMethods
{
    public class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var primes = numbers.PrimeNumbers();
            Console.WriteLine(string.Join(", ", primes)); // Output: 2, 3, 5, 7


            string input = "Hello, world!";
            string reversed = input.ReverseString();
            Console.WriteLine(reversed); // Output: "!dlrow ,olleH"


            var array = new[]
            {
                new { Name = "John", Age = 25, Gender = "Male" },
                new { Name = "Jane", Age = 30, Gender = "Female" },
                new { Name = "Bob", Age = 40, Gender = "Male" },
                new { Name = "Alice", Age = 35, Gender = "Female" }
            };

            foreach (var item in array)
            {
                Console.WriteLine($"Name: {item.Name}, Age: {item.Age}, Gender: {item.Gender}");
            }

        }
    }
}