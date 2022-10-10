using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonPoints
{
    class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Points { get; set; }
        public virtual void GetPoints()
        {
            if (Age > 30)
            {
                Points = 30;
            }
            else
            {
                Points = 20;
            }
        }
    }
}
