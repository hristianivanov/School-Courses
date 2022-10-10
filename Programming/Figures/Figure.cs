using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Figure
    {
        // todo add sides if need u
        public Figure(double size)
        {
            Size = size;
        }

        public double Size { get; set; }
        public int Sides { get; set; }
        //•	Метод Show(), който отпечатва размера на обекта в см.
        //•	Метод GetName(), като този метод връща низа " Figure ".
        //•	Дефинирайте метод GetArea(), като този метод връща лицето на фигурата.Използвайте формулата:

        public void Show()
        {

        }
        public virtual string GetName()
        {
            return "Figure";
        }
        public virtual double GetArea()
        {
            return (Sides * Math.Pow(Size,2)) / (4 * Math.Tan(Math.PI / Sides));
        }


    }
}
