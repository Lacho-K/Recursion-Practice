using System;
using System.Linq;

namespace RecursionHW_Ex1
{
    class Program
    {
        static int findSum(int[] A, int N)
        {
            if (N <= 0)
                return 0;
            return (findSum(A, N - 1) + A[N - 1]);
        }

        public static void Main()
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.Write(findSum(arr, arr.Length));
        }
    }
}
