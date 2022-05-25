using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racers
{
    class Participants
    {
        private string name;
        private int mark1;
        private int mark2;
        private int mark3;

        public Participants(string name, int mark1, int mark2, int mark3)
        {
            Name = name;
            Mark1 = mark1;
            Mark2 = mark2;
            Mark3 = mark3;
        }

        public string Name 
        { 
           get
            { 
                return this.name; 
            }
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("The name need to have 1 symbol");
                }
                name = value;
            }
        }

        public int Mark1 
        {
            get 
            {
                return this.mark1;
            }
            set
            {
                if (value<1 || value>100)
                {
                    throw new ArgumentException("The points is from 1 to 100");
                }
                mark1 = value;
            }
        }
        public int Mark2
        {
            get
            {
                return this.mark2;
            }
            set
            {
                if (value < 1 || value > 100)
                {
                    throw new ArgumentException("The points is from 1 to 100");
                }
                mark2 = value;
            }
        }
        public int Mark3
        {
            get
            {
                return this.mark3;
            }
            set
            {
                if (value < 1 || value > 100)
                {
                    throw new ArgumentException("The points is from 1 to 100");
                }
                mark3 = value;
            }
        }

        public int Sum()
        {
            return mark1 + mark2 + mark3;
        }
    }

}
