using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int fib = 1,sum = 0;
            for (int i = 1; i <= num; i++)
            {
                if (i >= 1)
                {
                    fib = sum + fib;
                    sum = fib - sum;
                    Console.Write($" {sum},");
                }
                else
                {
                    Console.Write($" {sum},");
                }
            }
        }
    }
}
