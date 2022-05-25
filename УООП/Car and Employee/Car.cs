using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_and_Employee
{
    class Car
    {
        public Car(string brand, string model, double displacement, int maxSpeed)
        {
            Brand = brand;
            Model = model;
            Displacement = displacement;
            MaxSpeed = maxSpeed;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public double Displacement { get; set; }
        public int MaxSpeed { get; set; }


    }
}
