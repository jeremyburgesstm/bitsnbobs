using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JeremyBurgess.Sorts;

namespace Sorts
{
    class Program
    {
        static void Main(string[] args)
        {
            SortTester tester = new SortTester();
            tester.TestSort(InsertionSort.Sort<int>);
            Console.ReadKey();
        }
    }
}
