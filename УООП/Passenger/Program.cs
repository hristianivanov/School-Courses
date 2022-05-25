using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passenger
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = Console.ReadLine().Split();
            List<string> input = Console.ReadLine().Split().ToList();
            Passenger passenger = new Passenger(name[0], name[1]);
            int counter = 1;

            while (input[0] != "END")
            {

                Ticket ticket = new Ticket(int.Parse(input[0]), int.Parse(input[1]), int.Parse(input[2]), double.Parse(input[3]));

                passenger.Tickets.Add(ticket);

                input = Console.ReadLine().Split().ToList();

            }

            for (int i = 0; i < passenger.Tickets.Count - 1; i++)
            {

                for (int j = i + 1; j < passenger.Tickets.Count; j++)
                {

                    if (passenger.Tickets[i].FromDate == passenger.Tickets[j].FromDate)
                    {

                        counter++;
                        passenger.Tickets.RemoveAt(j);
                        j--;
                    }

                }
                
                Console.WriteLine($"{passenger.FirstName} {passenger.LastName} have {counter} tickets from {passenger.Tickets[i].FromDate}.");
                counter = 1;

            }
        }
    }
}
