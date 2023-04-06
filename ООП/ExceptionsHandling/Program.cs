namespace ExceptionsHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double num1 = 0, num2 = 0, result = 0;
            char operation;

            try
            {
                num1 = double.Parse(Console.ReadLine()!);

                num2 = double.Parse(Console.ReadLine()!);
            }
            catch (NullReferenceException nre)
            {
                Console.WriteLine(nre.Message); return;
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message); return;
            }

            operation = char.Parse(Console.ReadLine()!);

            try
            {
                switch (operation)
                {
                    case '+':
                        result = num1 + num2; break;
                    case '-':
                        result = num1 - num2; break;
                    case '*':
                        result = num1 * num2; break;
                    case '/':
                        result = num1 / num2; break;
                    default:
                        throw new ArgumentException("Invalid Operation");
                }
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message); return;
            }
            catch (DivideByZeroException dbze)
            {
                Console.WriteLine(dbze.Message); return;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message); return;
            }

            Console.WriteLine("{0} - {1} = {2}", num1, operation, num2, result);
        }
    }

}
