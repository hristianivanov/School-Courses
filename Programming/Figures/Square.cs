using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Square : Figure
    {
        public Square(double size):base(size)
        {
            Sides = 4; 
        }

        public override string GetName()
        {
            return "Square";
        }

        public override double GetArea()
        {
            return Math.Pow(Size, 2);
        }
    }
}
