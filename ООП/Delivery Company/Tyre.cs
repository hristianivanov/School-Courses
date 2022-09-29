using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery_Company
{
    internal class Tyre
    {
        //<Гума1Налягане> <Гума1Възраст>
        //<Гума2Налягане> <Гума2Възраст>
        //<Гума3Налягане> <Гума3Възраст>
        //<Гума4Налягане> <Гума4Възраст>
        //1.3 1
        //1.5 2
        //1.4 2
        //1.7 4
        public Tyre(double preasure,int old)
        {
            Preasure = preasure;
            Old = old;
        }
        public double Preasure { get; set; }
        public int Old { get; set; }
    }
}
