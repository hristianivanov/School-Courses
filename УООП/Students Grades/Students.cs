using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_Grades
{
    class Students
    {
      
        public Students(string _name , double[] _grades)
        {
              Name = _name;
            Grades = _grades  ;
        }
        public string Name { get; set; }
        public double[] Grades { get; set; }

        public double Average(double[] grades)
        {
            double sum = 0;
            for (int i = 0; i < grades.Length; i++)
            {
                sum += grades[i];
            }
            return sum / grades.Length;
        }
        public override string ToString()
        {
            return $"{Name} {Average(Grades):f2}";
        }
         
        
    }
}
