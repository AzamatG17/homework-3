using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int fak = 1;
            for (int i = 1; i <= num; i++)
            {
                  fak *= i;
            }
            Console.WriteLine($" Faktorial : {fak}");
        }
    }
}
