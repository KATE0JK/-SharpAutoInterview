using System;

namespace SharpAutoInterview
{
    public static class BubbleSort
    {
        //swapping of elements method
        private static void Swap(ref int e1, ref int e2)
        {
            var temp = e1;
            e1 = e2;
            e2 = temp;
        }

        //bubble sort method
        public static int[] SortBubble(int[] array)
        {
            for (var i = 0; i < array.Length - 1; i++)
            {
                for (var j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }

            return array;

        }
    }
}