using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
   public class Company
    {
        private string name;
        private string date;
        private string bulstat;

        public Company(string name, string date, string bulstat)
        {
            Name = name;
            Date = date;
            Bulstat = bulstat;
        }
        public double Price { get; set; }
        public string Name
        {
            get => this.name;
            set
            {
                if (value==string.Empty)
                {
                    throw new ArgumentException("name is empty");
                }
                this.name = value;
            }
        }
        public string Date
        {
            get => this.date;
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException("date is empty");
                }
                this.date = value;
            }
        }
        public string Bulstat
        {
            get => this.bulstat;
            set
            {
                if (value.Length != 10)
                {
                    throw new ArgumentException("Invalid bulstat input.");
                }
                this.bulstat = value;
            }
        }
    }
}
