using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars_and_Employees_Lambda_Linq
{
    class Employee
    {
        public Employee(string name, int age, double salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
            Cars = new List<Car>();
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
        public List<Car> Cars { get; set; }

        public void BonusSalary()
        {
            if (Age>30)
            {
                Salary = Salary + Salary * 0.20;
            }
        }

    }
}
