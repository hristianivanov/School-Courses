using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class LimitedCompany: Company
    {
        private string id;
        private double capital;

        public LimitedCompany(string name,string date,string bulstat,string id,double capital)
            :base(name,date,bulstat)
        {
            this.Id = id;
            this.Capital = capital;
        }
        public string Id { get; set; }
        public double Capital { get; set; }

        //Първоначалният капитал за ЕООД е 2 лева.
        //10% от  разликата между актуалния и първоначалния капитал на  фирмата

        public double Duty()
        {
            return (Capital - 2) * 0.10;
        }
    }
}
