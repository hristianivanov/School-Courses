using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery_Company
{
    internal class Cargo
    {
        //<ТеглоНаТовара> <ТипНаТовара>
        //1000 fragile
        public Cargo(int weight, string type)
        {
            Weight = weight;
            Type = type;
        }
        public enum CargoType { fragile, flamable }
        public int Weight { get; set; }
        public string Type { get; set; }
    }
}
