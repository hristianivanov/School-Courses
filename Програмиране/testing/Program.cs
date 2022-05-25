using System;
using System.Collections.Generic;
using System.Linq;

namespace testing
{
    class Program
    {
        static void EvenSumRow(int[,] matrix)
        {
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                    if (matrix[i, j] % 2 == 0)
                    {
                        sum += matrix[i, j];
                    }
                }
                Console.WriteLine(sum);
                sum = 0;
            }
        }
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToList();

            var dict = new Dictionary<string, int>();

            foreach (var item in input)
            {
                if (dict.ContainsKey(item))
                {
                    dict[item]++;
                }
                else
                {
                    dict.Add(item.ToLower(), 1);
                }
            }

            foreach (var item in dict)
            {
                if (item.Value % 2 != 0)
                {
                    Console.Write($"{item.Key} ");
                }
            }

        }
    }
}
