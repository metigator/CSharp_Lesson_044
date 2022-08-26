using System;
using System.Linq;
using System.Text;

namespace Metigator44.L01
{
    internal class Program
    {  
        static void Main(string[] args)
        {
            for (byte c = 0; c < 255; ++c)
            {
                char ch = (char)c;
                string dec = c.ToString().PadLeft(3, '0');
                string hex = c.ToString("X");
                string binary = Convert.ToString(c, 2).PadLeft(8, '0');
                Console.WriteLine($"{dec,-12} {binary,-12} {hex,-12} {ch,-12}");
            }

            Console.ReadKey();
        }
    }
}
