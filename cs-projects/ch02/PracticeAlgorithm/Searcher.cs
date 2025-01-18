using System.Collections.Generic;
using Sorter;

namespace Searcher
{
    class Searcher
    {
        public static int BinarySearch<T>(T[] ienum, T searchKey)
        where T : IComparable<T>
        {
            Sorter.Sorter.Sorted<T>(ref ienum);
            var list = new List<T>(ienum);
            var low = 0;
            var high = list.Count - 1;
            var mid = (low + high) + 1 / 2;
            do
            {
                if (searchKey.CompareTo(list[mid]) == 0)
                {
                    return mid;
                }
                else if (searchKey.CompareTo(list[mid]) < 0)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
                mid = (low + high) + 1 / 2;
            } while (low <= high);
            return -1;
        }
    }
}
