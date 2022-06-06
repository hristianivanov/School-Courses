using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy
{
    internal class Pharmacy
    {
        private string name;
        private List<Medicine> medicines;

        public Pharmacy(string name)
        {
            this.Name = name;
            this.Medicines = new List<Medicine>(); // creating space for the Medicine class
        }

        public string Name
        {
            get => this.name;
            set
            {
                if (value.Length < 5)
                {
                    throw new ArgumentException("Name has to be at least 5 symbols long");
                }
                this.name = value;
            }
        }
        public List<Medicine> Medicines { get; set; }

        //TODO Methods 
        public void Order(Medicine medicine) // adding medicine
        {
            Medicines.Add(medicine);
        }
        public bool Sell(Medicine medicine) // removing medicine
        {
            // can't understand why is boolean method ?!?!?!?
            foreach (var item in Medicines)
            {
                if (item.Name == medicine.Name && item.Price == medicine.Price)
                {
                    Medicines.RemoveAll(item => item.Name == medicine.Name && item.Price == medicine.Price);
                    return true;
                }
            }
            return false;
        }
        public double CalculateTotalPrice() // calculate all medicines price
        {
            double sum = 0;
            foreach (var item in Medicines)
            {
                sum += item.Price;
            }
            return sum;
        }

        // override tostring method
        public override string ToString()
        {
            if (Medicines.Count > 0)
            {
                return $"Pharmacy {Name} has {Medicines.Count} medicines and they are:";
            } // need't else beacaues return brakes all the method if condition is true
            return $"Pharmacy {Name} has {Medicines.Count} medicines.";
        }

    }
}
