using System;
using System.Collections.Generic;
using System.Linq;

namespace FuncDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> isimler = new List<string> { "Meryem", "Ayla", "Haydar" };
            Func<string, bool> func = new Func<string, bool>(MeryemiBul);
            foreach(var item in isimler.Where(func))
            {
                Console.WriteLine(item);
            }
        }

        private static bool MeryemiBul(string arg)
        {
            return arg == "Meryem" || arg == "Ayla";
        }
    }
}
