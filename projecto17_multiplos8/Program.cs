using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projecto17_multiplos8
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            while (x<=500)
            {
                if (x%8==0)
                {
                    Console.WriteLine(x); // %
                }
                x = x + 1;
            }
            Console.ReadLine();
        }
    }
}
