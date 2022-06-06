using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos
{
    internal class Person
    { 
        public string Name { get; set; }
        public int Age { get; set; } 
        
        public List<Person> Persons { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            Persons = new List<Person>();
        }
    }
}
