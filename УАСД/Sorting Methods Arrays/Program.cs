using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Methods_Arrays
{
    class Program
    {
        static int[] BubbleSort(int[] array)
        {
            for(int i = 0; i<array.Length-1;i++)
            {
                for(int j = 0; j <array.Length - 1 - i; j++)
                {
                    if (array[j+1]>array[j])
                    {
                        int p = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = p;
                    }
                }
            }
            return array;
        }

        static int[] SelectionSort(int[] array)
        {
            int min = int.MinValue;
            int index;
            for(int i = 0; i<array.Length-1;i++)
            {
                min = array[i];
                index = i;
                for (int j = i+1; j < array.Length; j++)
                {
                    if (min > array[j])
                    {
                        min = array[j];
                        index = j;
                    }
                    int p = array[index];
                    array[index] = array[i];
                    array[i] = p;
                    
                }
            }
            return array;
        }
        static int[] InsSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int swapVar = array[i];
                int index = i;
                while (index>0&&array[index-1]>=swapVar)
                {
                    array[index] = array[index - 1];
                    index--;
                }
                array[index] = swapVar;
            }
            return array;
        }

        static void Main(string[] args)
        {
        }
    }
}
