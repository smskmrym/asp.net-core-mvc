using Microsoft.VisualBasic;
using System;
using System.ComponentModel.DataAnnotations;

namespace SingleResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            IMusteriDal musteriDal = new EfMusteriRepository();
            musteriDal.Kaydet();
                 
        }
    }
    class Musteri
    {
        public int Id { get; set; }

        public string Ad { get; set; }

 
    }
    interface IMusteriDal
    {
        void Kaydet();
    }
    class MusteriValidator
    {
        public static bool AdDogrula(string ad)
        {
            if (String.IsNullOrWhiteSpace(ad))
                return false;
            return true;
        }
    }
        class DpMusteriRepository : IMusteriDal
    {
        public void Kaydet()
        {
            Console.WriteLine("Dapper ile Kaydedildi");
        }
    }
    class EfMusteriRepository : IMusteriDal
    {
        public void Kaydet()
        {
            Console.WriteLine("Ef ile Kaydedildi");
        }

    }
}
