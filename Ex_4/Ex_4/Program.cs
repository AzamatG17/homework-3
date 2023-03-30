using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i < 100; i++)
            {
                if (i % num == 0)
                {
                    Console.Write($" {i},");
                }
            }
            Console.WriteLine();
        }
    }
}
