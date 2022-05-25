using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cars_and_Employees_Lambda_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> inputEmployee = Console.ReadLine().Split().ToList();

            List<Employee> employees = new List<Employee>();



            for (int i = 0; i < n; i++)
            {

                employees.Add(new Employee(inputEmployee[0],
                    int.Parse(inputEmployee[1]),
                    double.Parse(inputEmployee[2])
                    ));

                employees[i].BonusSalary();

                while (inputEmployee[0].ToLower() != "end")
                {
                    List<string> inputCar = Console.ReadLine().Split().ToList();

                    Car car = new Car(inputCar[0],
                        inputCar[1],
                        double.Parse(inputCar[2]),
                        int.Parse(inputCar[3])
                        );

                    employees[i].Cars.Add(car);
                   
                }

                inputEmployee.Clear();
                inputEmployee = Console.ReadLine().Split().ToList();

            }

          

            for (int i = 0; i < employees.Count; i++)
            {

                Console.WriteLine($"{employees[i].Name} have {employees[i].Cars.Count} cars.");

            }
            

        }
    }
}
