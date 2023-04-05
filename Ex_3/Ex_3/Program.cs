using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());
            int larg = Math.Max(Math.Max(num1, num2),Math.Max(num3, num4));
            int smal = Math.Min(Math.Min(num1, num2),Math.Min(num3, num4));
            int diff = larg - smal;
            Console.WriteLine($" differens : {diff}");
        }
    }
}
