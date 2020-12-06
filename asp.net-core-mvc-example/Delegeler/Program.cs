using System;

namespace Delegate
{
    delegate void mydelegate(int sayi1, int sayi2);
    class Program
    {
        static void Main(string[] args)
        {
            mydelegate delegem = new mydelegate(Topla);
            delegem += Carp;
            delegem.Invoke(2, 3);
                
        }
        static void Topla(int sayi1, int sayi2)
        {
            Console.WriteLine($"Toplam: {sayi1 + sayi2}");
        }
        static void Carp(int sayi1, int sayi2)
        {
            Console.WriteLine($"Çaarpım:{sayi1 * sayi2}");
        }
    }
}
