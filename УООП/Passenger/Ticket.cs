using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passenger
{
    class Ticket
    {
        public Ticket(int fromDate, int toDate, int distance, double price)
        {
            FromDate = fromDate;
            ToDate = toDate;
            Distance = distance;
            Price = price;
        }

        public int FromDate { get; set; }
        public int ToDate { get; set; }
        public int Distance { get; set; }
        public double Price { get; set; }
    }
}
