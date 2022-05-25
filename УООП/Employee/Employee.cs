using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Employee
    {
        private string name;
        private int age;
        private double salary;

        public Employee(string _name, int _age, double _salary)
        {
            Name = _name;
            Age = _age;
            Salary = _salary;
        }

        public string Name
        {
            set { name = value; }
            get { return name; }

        }
        public int Age
        {
            set { age = value; }
            get { return age; }
        }
        public double Salary
        {
            set { salary = value; }
            get { return salary; }
        }

        public void IncreaseSalary(double bonus)
        {
            if (age < 30)
            {
                salary = salary + bonus / 2 / 100 * salary;
            }
            else
            {
                salary = salary + bonus / 100 * salary;
            }
        }

        public string Print()
        {
            return $"{name} get {salary:f2} leva";
        }
    }
}
