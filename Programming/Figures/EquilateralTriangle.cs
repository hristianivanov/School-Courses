using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class EquilateralTriangle : Figure
    {
        //•	Конструктор, който извиква конструктора на базовия клас

        public EquilateralTriangle(double size):base(size)
        {
            Sides = 3;
        }
        //•	Пренапишете метода GetName(), като този метод връща низа "Equilateral triangle".

        public override string GetName()
        {
            return "EquilateralTriangle";
        }

        //•	Пренапишете метода GetArea(), като този метод връща лицето на триъгълника,
        //като триъгълникът се приема за равностранен, със страна size.Използвайте формулата: 

        public override double GetArea()
        {
            return Math.Pow(Size, 2) * Math.Sqrt(3) / 4;
        }



    }
}
