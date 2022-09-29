using System;
using System.Collections.Generic;
using System.Linq;

namespace Delivery_Company
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                Car car = new Car(input[0],
                    int.Parse(input[1]),
                    int.Parse(input[2]),
                    int.Parse(input[3]),
                    input[4],
                    double.Parse(input[5]),
                    int.Parse(input[6]),
                    double.Parse(input[7]),
                    int.Parse(input[8]),
                    double.Parse(input[9]),
                    int.Parse(input[10]),
                    double.Parse(input[11]),
                    int.Parse(input[12])
                    );

                cars.Add(car);
            }

            var cmdArg = Console.ReadLine();

            // “fragile” или “flamable”.


            // Ако командата е “fragile”, то отпечатайте всички коли с тип на товара “fragile”с гуми с налягане< 1;
            // ако командата е “flamable”, отпечатайте всички коли с тип на товара “flamable” и мощност на двигателя > 250.


            // Колите трябва да се изведат в реда, в който са подадени като входни данни.


            if (cmdArg == "fragile")
            {
                cars = new List<Car>(cars.Where(x => x.Cargo.Type == cmdArg));
                foreach (Car car in cars)
                {
                    for (int i = 0; i < car.Tyres.Count; i++)
                    {
                        if (car.Tyres[i].Preasure >= 1)
                        {
                            return;
                        }
                    }
                    Console.WriteLine(car.Model);
                }
            }
            else
            {
                cars = new List<Car>(cars.Where(x => x.Cargo.Type == cmdArg));
                foreach (Car car in cars)
                {
                    if (car.Engine.Power > 250)
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }
        }
    }
}
