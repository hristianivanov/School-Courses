using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Circle : Figure
    {
        public Circle(double size) : base(size)
        {
            Sides = 0;
        }
        public override string GetName()
        {
            return "Circle";
        }
        public override double GetArea()
        {
            return Math.PI * Math.Pow(Size, 2);
        }
    }
}
