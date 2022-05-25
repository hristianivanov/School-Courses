using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_and_Reserve_Team
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }

        public Person (string _name,int _age,decimal _salary)
        {
            Name = _name;
            Age = _age;
            Salary = _salary;
        }
    }
}
