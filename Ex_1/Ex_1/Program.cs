using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write num 10 : ");
            int num = int.Parse(Console.ReadLine());
            int num2, i = 1;
            string to = "";
            while (num != 0)
            {
                to += num % 2;
                num2 = num /= 2;
                num = num2;

            }
            //Console.WriteLine(to);
            string wo = "";
            for (int j = to.Length - 1; j >= 0; j--)
            {
                Console.Write(to[j]);
            }

            Console.WriteLine();
        }
    }
}
