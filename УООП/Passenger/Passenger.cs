using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passenger
{
    class Passenger
    {
        public Passenger(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Tickets = new List<Ticket>();
        }


        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Ticket> Tickets { get; set; }

    }
}
