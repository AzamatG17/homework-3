using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" : ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i < num; i++)
            {
                int sum = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        sum += j;
                    }
                }
                if (sum == i)
                {
                    Console.Write($" {i},");
                }
            }
            Console.WriteLine();
        }
    }
}
