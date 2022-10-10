using System;
using System.Text.RegularExpressions;

namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "fhdsjhfjHKJHkjh9232";
            string pattern = @"^[\w]+[\d]+$";

            Regex regex = new Regex(pattern);
 
        }
    }
}
