using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figure> figureList = new List<Figure>();
            using (StreamReader reader = new StreamReader(@"..\..\..\figures.txt"))
            {
                string line = string.Empty;
                if (File.Exists(@"..\..\..\output.txt"))
                {
                    File.Delete(@"..\..\..\output.txt");
                }
                while ((line = reader.ReadLine()) != "END")
                {
                    string[] tokens = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    string type = tokens.First();
                    double size = double.Parse(tokens.Last());
                    switch (type)
                    {
                        case "Circle":
                            Circle circle = new Circle(size);
                            figureList.Add(circle);
                            break;
                        case "EquilateralTriangle":
                            EquilateralTriangle triangle = new EquilateralTriangle(size);
                            figureList.Add(triangle);
                            break;
                        case "Square":
                            Square square = new Square(size);
                            figureList.Add(square);
                            break;
                    }
                }
            }
            using (StreamWriter writer = new StreamWriter(@"..\..\..\output.txt", true))
            {
                figureList.ForEach(figure => writer.WriteLine($"{figure.GetName()}: Size: {figure.Size} sm, Area: {figure.GetArea():f2} sq sm"));
            }

        }
    }
}
