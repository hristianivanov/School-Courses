using System;
using System.Linq;

namespace Demos
{
    internal class Program
    {
        public static bool Idk(Person person)
        {
            if (person.Persons.Contains(person))
            {
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {


        }
    }
}
