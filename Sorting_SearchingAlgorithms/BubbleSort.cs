using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_SearchingAlgorithms
{
    class BubbleSort
    {
        public static void PrintArray()
        {
            int[] Arrays = { 34, 67, 45, 12, 89 };
            BubbleSortAlgo(Arrays);
            foreach (int List in Arrays)
            {
                Console.WriteLine(List);
            }
        }
        public static void BubbleSortAlgo(int[] Arrays)
        {
            int n = Arrays.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (Arrays[j] > Arrays[j + 1])
                    {
                        // swap temp and Arrays[i]
                        int temp = Arrays[j];
                        Arrays[j] = Arrays[j + 1];
                        Arrays[j + 1] = temp;
                    }
        }
    }
}
