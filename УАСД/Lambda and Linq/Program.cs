using System;
using System.Linq;
using System.Text;


namespace Lambda_and_Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ZAD 1
            //var input = Console.ReadLine()
            //    .Split()
            //    .OrderBy(x => x).ToArray();
            //foreach (var item in input)
            //{
            //    Console.Write($"{item} ");
            //}

            // ZAD 2
            var immuneSystemStrenght = int.Parse(Console.ReadLine());
            var virusName = Console.ReadLine();
            var virusStrenght = 0;
            var defeatingTime = 0;
            var mins = 0;
            var seconds = 0;

            while (virusName != "End".ToLower())
            {
                foreach (var letter in virusName)
                {
                    virusStrenght += (int)letter;
                }

                virusStrenght /= 3;
                defeatingTime = virusStrenght * virusName.Length;
                mins = defeatingTime / 60;
                seconds = defeatingTime % 60;

                virusName = Console.ReadLine();
            }
            Console.WriteLine($"{mins} {seconds}");
            
        }
    }
}
