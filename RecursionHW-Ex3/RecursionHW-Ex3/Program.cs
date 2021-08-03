using System;

namespace RecursionHW_Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(Factorial(num));
        }

        static int Factorial(int n)
        {
            if(n > 1)
            {
                return Factorial(n - 1) * n;
            }
            return 1;
        }
    }
}
