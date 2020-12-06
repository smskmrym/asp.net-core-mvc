using System;
using System.Collections.Generic;

namespace behavior_of_objects
{
    class Program
    {
        /* 
         Objelerin davranışı
        
         static void Main(string[] args)
         {
               string ad = string.Empty;
               List<string> isimler = new List<string>();


               List<Musteri> musteris = new List<Musteri>();  

               for (int i=0; i<30; i++)
               {
                   ad = FakeData.NameData.GetCompanyName();
                   isimler.Add(ad);
               }
               foreach ( var item in isimler)
               {
                   Console.WriteLine(item);
               }
               for (int i = 0; i < 30; i++)
               {
                   Musteri musteri = new Musteri();
                   musteri.Ad = FakeData.NameData.GetCompanyName();
                   musteris.Add(musteri);
               }
               foreach (var item in musteris)
               {
                   Console.WriteLine(item.Ad);
               }
           }
       }
       class Musteri
       {
           public string Ad { get; set; }
       }

         }
        */

        // extension metod
        static void Main(string[] args)
        {
            MatamatikselIslem islem = new MatamatikselIslem();
            Console.WriteLine(islem.Cikar(10, 2));
        }
    }

        class MatamatikselIslem
        {
            public int Topla(int sayi1, int sayi2)
            {
                return sayi1 + sayi2;
            }

            public int Carp(int sayi1, int sayi2)
            {
                return sayi1 * sayi2;
            }
        }
        static class MatExtension
        {
            public static int Cikar(this MatamatikselIslem islem, int sayi1, int sayi2)
            {
                return sayi1 - sayi2;
            }
        }
    
}

