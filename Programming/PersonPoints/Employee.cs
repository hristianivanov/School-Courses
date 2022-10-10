using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonPoints
{
    class Employee : Person
    {
        public Employee(string name, int age) : base(name, age)
        {

        }
        public int Years { get; set; }
        public override void GetPoints()
        {
            if (Years > 10)
            {
                Points += Points * 0.2;
            }
        }
    }
}
