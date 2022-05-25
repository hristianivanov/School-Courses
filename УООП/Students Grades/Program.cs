using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_Grades
{
    class Program
    {
        static double[] Converter(string[] input)
        {
            double[] numbers = new double[input.Length-2];
            int j=0;
            for (int i = 2; i < input.Length; i++)
            {
              numbers[j] =  double.Parse(input[i]);
                j++;
            }
            return numbers;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Students> list = new List<Students>();
            for (int i = 0; i < n; i++)
            {
                string[] arr = Console.ReadLine().Split().ToArray();

                string name = $"{arr[0]} {arr[1]}";

                double[] grades = Converter(arr);

                Students st = new Students(name, grades);

                list.Add(st);

            }
            foreach (var student in list)
            {
                Console.WriteLine(student);
            }

        }
    }
}
