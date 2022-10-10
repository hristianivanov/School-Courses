using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class SoleTrader : Company
    {
        private string traderName;
        private double startCapital;
        private double capital;

        public SoleTrader(string name,string date,string bulstat,string traderName, double startCapital, double capital)
            :base(name,date,bulstat)
        {
            this.TraderName = traderName;
            this.StartCapital = startCapital;
            this.Capital = capital;
        }

        public string TraderName
        {
            get => this.traderName;
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException("name is empty");
                }
                this.traderName = value;
            }
        }
        public double StartCapital { get; set; }
        public double Capital { get; set; }
        //15% от  разликата между актуалния и първоначалния капитал на  фирмата
        public double Duty()
        {
            return (Capital - StartCapital) * 0.15;
        }
    }
}
