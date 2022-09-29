using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractions
{
    internal class RacionalNumber
    {
        private int numerator; // числител
        private int denumerator; // знаменател

        public RacionalNumber(int numerator, int denumerator)
        {
            Numerator = numerator;
            Denumerator = denumerator;
            if (Numerator == Denumerator)
            {
                Nums = "1";
            }
            else
            {
                Nums = $"{Numerator / GreatestCommonDivider(Numerator, Denumerator)}/{Denumerator / GreatestCommonDivider(Numerator, Denumerator)}";
            }
        }

        public int Numerator { get; set; }
        public int Denumerator { get; set; }

        public string Nums { get; set; }
        public static int GreatestCommonDivider(int a, int b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }

            return a | b;
        }
    }
}
