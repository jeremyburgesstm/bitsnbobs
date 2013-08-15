/*
 * This source file is part of one of Jeremy Burgess's samples.
 *
 * Copyright (c) 2013 Jeremy Burgess 
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 * THE SOFTWARE.
 */

using System;
using System.Collections.Generic;

namespace JeremyBurgess.Sorts
{
    /// <summary>
    /// InsertionSort class - does what it says on the tin!
    /// 
    /// Created this for use on small, usually sorted, list which 
    /// is very frequently sorted. Mainly thought this would be quicker than 
    /// .NET quicksort for the data characteristics I was looking at.
    /// </summary>
    public static class InsertionSort
    {
        public static void Sort<T>(IList<T> listToSort)
        {
            Sort(listToSort, Comparer<T>.Default.Compare);
        }

        public static void Sort<T>(IList<T> listToSort, Comparer<T> comparer)
        {
            Sort(listToSort, comparer.Compare);
        }

        public static void Sort<T>(IList<T> listToSort, Comparison<T> typeComparison)
        {
            // Iterate through list.
            for (int i = 1; i < listToSort.Count; ++i)
            {
                // First comparison done explicitly to avoid the need for any unnecessary
                // copies or assignments.
                if (typeComparison(listToSort[i], listToSort[i - 1]) < 0)
                {
                    // Set the hole position to 1 down
                    int holePos = i - 1;
                    T valueToMove = listToSort[i];
                    listToSort[i] = listToSort[i - 1];
                    // While we find unsorted elements, iterate through the list downwards moving elements up.
                    while (holePos > 0 && typeComparison(valueToMove, listToSort[holePos - 1]) < 0)
                    {
                        listToSort[holePos] = listToSort[holePos - 1];
                        --holePos;
                    }
                    listToSort[holePos] = valueToMove;
                }
            }
        }
    }
}
