using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split(' ').ToList();
            Employee employeе = new Employee(input[0] + " " + input[1], int.Parse(input[2]),
            double.Parse(input[3]));

            double bonus = double.Parse(Console.ReadLine());
            employeе.IncreaseSalary(bonus);
            Console.WriteLine(employeе.Print());
        }
    }
}
