namespace CustomEventHandler
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount("1234567890");

            account.TransactionMade += (sender, transaction) =>
            {
                Console.WriteLine($"Transaction: {transaction.TransactionType}, Amount: {transaction.Amount}, Date: {transaction.Date}");
            };

            account.Deposit(1000);
            account.Withdraw(500);
            account.Deposit(2000);
        }

        private static void ThirdEvent(Statistic statistic)
        {
            statistic.NumberChecking += OnNumberChecked!;

            Console.Write("Type number: ");
            int number = int.Parse(Console.ReadLine()!);
            statistic.Number = number;
        }

        private static void SecondEvent()
        {
            for (int i = 0; i < 2; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = input[0];
                int age = int.Parse(input[1]);

                Person person = new Person(name, age);
                person.PersonCreated += PrintPersonsInfo!;
                person.OnPersonCreated();
            }
        }

        private static void FirstEvent(Statistic statistic)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6 };
            statistic.Calculating += PrintMethod!;
            statistic.Calculate(nums);
        }

        private static void PrintPersonsInfo(object sender, PersonEventArgs e)
        {
            Console.WriteLine($"Created a new person with name {e.Name} and age {e.Age}");
        }
        private static void PrintMethod(object obj, MyEventArgs e)
        {
            Console.WriteLine($"Min = {e.Min}");
            Console.WriteLine($"Max = {e.Max}");
            Console.WriteLine($"Average = {e.Average}");
            Console.WriteLine($"Sum = {e.Sum}");
        }

        private static void OnNumberChecked(object obj, NumberCheckedEventArgs e)
        {
            if (e.Number % 2 == 0)
                Console.WriteLine("Odd");
            else
                Console.WriteLine("Even");
        }
    }
}