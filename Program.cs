using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    internal class Program
    {
        static void SelectionSort(int []arr)
        {
            for (int i = 0; i < arr.Length-1; i++)
            {
                int min = arr[i], index = 0, flag = 0;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (min > arr[j])
                    {
                        min = arr[j];
                        index = j;
                        flag = 1;
                    }
                }
                if(flag==1)
                {
                    int temp = arr[i];
                    arr[i] = min;
                    arr[index] = temp;
                }
            }
            Console.WriteLine(string.Join(" ", arr));
        }
        static void Main(string[] args)
        {
            SelectionSort(new int[] { 6, 4, 5, 3, 2, 1, 7 });
            SelectionSort(new int[] { -1, -5, 5, 3, 0, 1, 7,100 });
            Console.ReadLine();
        }
    }
}
