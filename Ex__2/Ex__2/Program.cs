using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex__2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" : ");
            int fak = int.Parse(Console.ReadLine());
            int num = 1;
            for (int i = 1; i <= fak; i++)
            {
                num *= i;
            }
            Console.WriteLine($" Faktorial : {num}");
        }
    }
}
