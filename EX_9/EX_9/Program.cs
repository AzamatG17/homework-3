using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" : ");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 != 0 && num % 3 != 0)
            {
                Console.WriteLine($"{num} is a prime num");
            }
            else
            {
                Console.WriteLine($"{num} is not a prime num");
            }
            Main(args);
        }
    }
}
