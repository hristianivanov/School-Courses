using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_and_Employee
{
    class Employee
    {
        public Employee(string name, int age, decimal salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
            Cars = new List<Car>();
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
        public List<Car> Cars { get; set; }
    }
}
