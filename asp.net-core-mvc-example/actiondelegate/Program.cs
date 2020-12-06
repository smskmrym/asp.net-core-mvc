using System;
using System.Collections.Generic;

namespace actiondelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayilar = new List<int> { 1, 2, 3, 4, 5 };

            Action<int> action = new Action<int>(SayiGetir);
            action.Invoke(1);

            sayilar.ForEach(action);
            sayilar.ForEach(SayiGetir);

        }
        private static void SayiGetir(int obj)
        {
            Console.WriteLine(obj.ToString());
        }
    }
}
