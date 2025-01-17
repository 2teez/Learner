using System.Collections.Generic;

namespace Sorter
{
    public enum Order : byte
    {
        Descending = 1,
        Ascending,
    }

    class Sorter
    {
        public static void Sorted<T>(ref T[] ienum, Order state = Order.Ascending)
        where T : IComparable<T>
        {
            var list = new List<T>(ienum);
            for (var i = 0; i < list.Count; i++)
            {
                for (var j = 0; j < list.Count; j++)
                {
                    if (list[i].CompareTo(list[j]) > 0)
                    {
                        var temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
            }

            ienum = CopyData<T>(list.ToArray<T>(), state);
        }

        private static T[] CopyData<T>(IEnumerable<T> ienum, Order state = Order.Ascending)
        {
            var list = new List<T>(ienum);
            T[] newArray = new T[list.Count];
            int counter = 0;
            if (state == Order.Ascending)
            {
                for (var i = list.Count - 1; i >= 0; i--)
                {
                    newArray[counter++] = list[i];
                }
            }
            else
            {
                for (var i = 0; i < list.Count; ++i)
                {
                    newArray[i] = list[i];
                }
            }
            return newArray;
        }
    }
}
