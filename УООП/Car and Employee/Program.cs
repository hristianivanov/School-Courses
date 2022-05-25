using System;
using System.Threading.Tasks;
using System.Text;
using System.Linq;
using System.Collections.Generic;


namespace Car_and_Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputEmployee = Console.ReadLine().Split().ToList();

            Employee employee = new Employee( inputEmployee[0]
                , int.Parse(inputEmployee[1])
                , decimal.Parse(inputEmployee[2]) 
                );

            List<string> inputCar = Console.ReadLine().Split().ToList();

            while (inputCar[0].ToLower()!="end")
            {
                Car car = new Car(inputCar[0]
                    , inputCar[1]
                    , double.Parse(inputCar[2])
                    , int.Parse(inputCar[3])
                    );

                employee.Cars.Add(car);

                inputCar = Console.ReadLine().Split().ToList();
            }
        }
    }
}
