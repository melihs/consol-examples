using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3AsalSayilar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("10'dan küçük asal sayıların toplamı 17'dir; 2 + 3 + 5 + 7 = 17 2.000.000'dan küçük tüm asal sayıların toplamını bulun");
            Console.WriteLine("***************************************************************");

            //değişkenleri tanımlayalım
            int i;
            int[] aSayilar;
            List<int> toplam = new List<int>();
            toplam.Add(2);
            for (i = 2; i < 10; i++)
            {
                aSayilar = new int[i];

            
            foreach (var item in aSayilar)
            {
                while (item % 1 == 0 && item % 2 != 0)
                {
                    toplam.Add(item);
                }
            }
        }
            Console.WriteLine("asal sayıların toplamı= {0}", toplam.Sum());
            Console.ReadKey();
        }
    }
}
