using System;
using System.Linq;
namespace RecursionHW_Ex2
{
    class Program
    {
        static void ReverseArr(int[] array, int leftIndex, int rightIndex)
        {
            int temp;
            if (leftIndex <= rightIndex)
            {
                temp = array[leftIndex];
                array[leftIndex] = array[rightIndex];
                array[rightIndex] = temp;
                ReverseArr(array, leftIndex + 1, rightIndex - 1);
            }
        }

        public static void Main()
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            ReverseArr(arr, 0, arr.Length - 1);
            Console.WriteLine(String.Join(' ', arr));
        }
    }
}
