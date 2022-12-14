using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_SearchingAlgorithms
{
    public class InsertionSortAlgo
    {
        public  static void PrintArray()
        {
            //string array
            string[] names = { "Preeti", "Tanya", "Somya", "Radhika" };
            InsertionSort(names);
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
        public  static void InsertionSort(IComparable[] array)
        {
            int i, j;

            for (i = 1; i < array.Length; i++)
            {
                IComparable value = array[i];
                j = i - 1;
                while ((j >= 0) && (array[j].CompareTo(value) > 0))
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = value;
            }
        }
        
    }
}
