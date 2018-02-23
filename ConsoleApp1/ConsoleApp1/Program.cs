using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" a ededini daxil edin");
            var a = Console.ReadLine();
            Console.WriteLine(" b ededini daxil edin");
            var b = Console.ReadLine();
            int c = Convert.ToInt32(a) + Convert.ToInt32(b);
            Console.WriteLine(a + "+" + b + "=" + c);


        }
    }
}
