using System;

namespace Sorting_SearchingAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 For Insertion Sort");
            Console.WriteLine("Enter 2 For Bubble Sort");
            Console.WriteLine("Enter 3 For Merge Sort");
            Console.WriteLine("Enter 4 For Anagram Detection");
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    InsertionSortAlgo.PrintArray();
                    Console.ReadKey();
                    break;
                case 2:
                    BubbleSort.PrintArray();
                    Console.ReadKey();
                    break;
                case 3:
                    MergeSort.PrintArray();
                    break;
                case 4:
                    Anagram.AnagramMethod();
                    break;
            }           
            
        }
    }
}