using System;
using System.Collections.Generic;

namespace PredicateDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> isimler = new List<string> { "Meryem", "Ayla", "Haydar" };
            Predicate<string> predicate = new Predicate<string>(MeryemiBul);

            Console.WriteLine(isimler.Find(predicate));
            Console.WriteLine(isimler.Find(MeryemiBul));
        }

        private static bool MeryemiBul(string obj)
        {
            return obj.ToLower() == "meryem";
        }
    }
}
