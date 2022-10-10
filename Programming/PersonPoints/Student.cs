using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonPoints
{
    class Student : Person
    {
        public Student(string name, int age, double success) : base(name, age)
        {
            Success = success;
        }
        public double Success { get; set; }
        public override void GetPoints()
        {
            if (Success > 5.5)
            {
                Points += Points * 0.3;
            }
        }
    }
}
