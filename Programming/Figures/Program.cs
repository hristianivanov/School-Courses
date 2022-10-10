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
                    
                    using (StreamWriter writer = new StreamWriter(@"..\..\..\output.txt",true))
                    {
                        switch (type)
                        {
                            case "Circle":
                                Circle circle = new Circle(size);
                                writer.WriteLine($"{circle.GetName()}: Size: {circle.Size} sm, Area: {circle.GetArea():f2} sq sm");
                                break;
                            case "EquilateralTriangle":
                                EquilateralTriangle triangle = new EquilateralTriangle(size);
                                writer.WriteLine($"{triangle.GetName()}: Size: {triangle.Size} sm, Area: {triangle.GetArea():f2} sq sm");
                                break;
                            case "Square":
                                Square square = new Square(size);
                                writer.WriteLine($"{square.GetName()}: Size: {square.Size} sm, Area: {square.GetArea():f2} sq sm");
                                break;
                        }

                    }
                }
            }
        }
    }
}
