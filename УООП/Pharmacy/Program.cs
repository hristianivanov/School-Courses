using System;
using System.Linq;
using System.Text;

namespace Pharmacy
{
    internal class Program
    {
        public static string Capitalizing(string input)
        {
            string output = input.Substring(0, 1).ToUpper() + input.Substring(1); // make sure the first letter is capitalized
            return output;
        }

        static void Main(string[] args)
        {
            var pharmacyName = Console.ReadLine();
            var pharmacy = new Pharmacy(pharmacyName); 

            var input = Console.ReadLine().Split().ToList();
            try
            {
                while (Capitalizing(input[0]) != "End")
                {
                    if (Capitalizing(input[0]) == "Order" || Capitalizing(input[0]) == "Sell")
                    {
                        Medicine medicine = new Medicine(input[1],
                                double.Parse(input[2])
                                );

                        if (Capitalizing(input[0]) == "Order")
                        {
                            pharmacy.Order(medicine);
                        }
                        else if(pharmacy.Sell(medicine))
                        {
                            // really can't undestand why the fuck is bolean method
                            // when the method I did make everything I want...
                            // deleting object can be done in method or here 
                            // I've done it in method
                            
                            Console.WriteLine($"{medicine.Name} has been purchased"); // need't output for test

                        }
                        else
                        {
                            Console.WriteLine($"We don't have {medicine.Name}");
                        }
                        
                    }
                    else 
                    {
                        pharmacyName = Console.ReadLine();
                        pharmacy.Name = pharmacyName;
                    }

                    input = Console.ReadLine().Split().ToList();
                }
                // can't see what is the last condition on the exam

                // maybe if we have medicines or not
                if (pharmacy.Medicines.Count>0)
                {
                    Console.WriteLine(pharmacy.ToString());
                    foreach (var item in pharmacy.Medicines)
                    {
                        Console.WriteLine(item.ToString());
                    }
                    Console.WriteLine(new String('-',30)); // repeat action
                    Console.WriteLine($"Total Price: {pharmacy.CalculateTotalPrice():f2}");
                }
                else
                {
                    Console.WriteLine(pharmacy.ToString());
                }
                Console.ReadKey();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
