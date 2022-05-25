using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            try
            {
                while (input != "Close")
                {
                    string[] information = input.Split();
                    string command = information[0];


                    switch (command)
                    {
                        case "Add":
                            Market.Add(information[1],
                            information[2],
                            double.Parse(information[3]),
                            double.Parse(information[4])
                            ); break;

                        case "Sell":
                            Market.Sell(information[1],
                           information[2],
                           double.Parse(information[3])
                           ); break;

                        case "Update":
                            Market.Update(information[1],
                           double.Parse(information[2])
                           ); break;

                        case "PrintA":
                            Market.PrintA(); break;

                        case "PrintU":
                            Market.PrintU(); break;

                        case "PrintD":
                            Market.PrintD(); break;

                        case "Calculate":
                            Console.WriteLine($"{Market.Calculate():F2}"); break;
                        default:
                            Console.WriteLine("Type correct command from the command list");
                            break;
                    }

                    input = Console.ReadLine();
                }
            }

            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

        }
    }
}
