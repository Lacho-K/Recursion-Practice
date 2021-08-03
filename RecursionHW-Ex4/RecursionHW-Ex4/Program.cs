using System;

namespace RecursionHW_Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.Write(DrawTop(n));
            Console.Write(DrawBottom(0,n));
        }
        static string DrawTop(int n)
        {
            if(n > 0)
            {
                string tempStr = "\n";
                if(n == 1)
                {
                    tempStr = null;
                }
                return new string('*', n) + tempStr + DrawTop(n - 1);    
            }
            return null;
        }
        static string DrawBottom(int n, int final)
        {
            if(n <= final)
            {
                return new string('#', n) + "\n" + DrawBottom(n + 1, final);
            }
            return null;
        }
    }
}
