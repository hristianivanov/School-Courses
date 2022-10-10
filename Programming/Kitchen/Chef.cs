using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen
{
    class Chef
    {
        public Chef(string name, string department)
        {
            Name = name;
            Department = department;
            IsOnABreak = false;
        }

        public string Name { get; set; }
        public string Department { get; set; }
        public double Price { get; set; }
        public List<Dish> Dishes { get; set; }
        public bool IsOnABreak { get; set; }

    }
}
