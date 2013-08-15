using System;
using System.Collections.Generic;

namespace JeremyBurgess.Sorts
{
    class SortTester
    {
        public void TestSort(Action<IList<int>, Comparison<int>> sortMethod)
        {
            List<int> unsortedIntegers = GenerateRandomIntegers(100);
            // Log out the unsorted ints.
            Console.WriteLine("Unsorted integers:");
            for (int i = 0; i < unsortedIntegers.Count; ++i)
            {
                Console.WriteLine(unsortedIntegers[i]);
            }
            sortMethod(unsortedIntegers, Comparer<int>.Default.Compare);

            Console.WriteLine("Sorted integers:");
            bool failed = false;
            for (int i = 0; i < unsortedIntegers.Count; ++i)
            {
                Console.WriteLine(unsortedIntegers[i]);
                if (i > 0 && unsortedIntegers[i] < unsortedIntegers[i - 1])
                {
                    failed = true;
                }
            }
            if (failed)
            {
                Console.WriteLine("**************FAILED****************");
            }
            else
            {
                Console.WriteLine("**************SUCCEEDED****************");
            }
        }

        private List<int> GenerateRandomIntegers(int count)
        {
            Random generator = new Random();
            List<int> integers = new List<int>();
            for (int i = 0; i < count; ++i)
            {
                integers.Add(generator.Next(10000));
            }
            return integers;
        }
    }
}
