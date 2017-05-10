using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_sayiGirmeVebulma
{
    class Program
    {
        static void Main(string[] args)
        {
            //Girilen sayıların en büyüğü-en küçüğü-pozitif sayı adedi-negatif sayı adedi-toplam-ortalamasını bulma
            Console.WriteLine("Girilen sayıların en büyüğü-en küçüğü-pozitif sayı adedi-negatif sayı adedi-toplam-ortalamasını bulma");

            //değişkenleri tanımlayalım
            int sayiAdedi,negSayi=0,pozSayi=0;
            int[] sayi;

            //girdi
            Console.Write("Sayı adedi girin: ");
            sayiAdedi = int.Parse(Console.ReadLine());
            Console.WriteLine();
            sayi =new int[sayiAdedi];
            for (int i = 1; i <=sayiAdedi; i++)
            {
                Console.Write("{0}. sayıyı girin: ",i);
                sayi[i-1]=int.Parse(Console.ReadLine());
                Console.WriteLine();
            }

            //pozitif-negatif kontrolü
            foreach (var item in sayi)
            {
                if (item > 0)
                {
                  pozSayi++;  
                }
                else
                {
                 negSayi++;
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("************************************************************");
            Console.WriteLine("girilen sayı adedi: {0}",sayiAdedi);
            Console.WriteLine("girilen sayıların pozitif sayı adedi: {0}", pozSayi);
            Console.WriteLine("girilen sayıların negatif sayı adedi: {0}", negSayi);
            Console.WriteLine("girilen sayıların en büyük olanı: {0}",sayi.Max());
            Console.WriteLine("girilen sayıların en küçük olanı: {0}",sayi.Min());
            Console.WriteLine("girilen sayıların toplamı: {0}",sayi.Sum());
            Console.WriteLine("girilen sayıların ortalaması: {0}",sayi.Average());
            Console.ReadLine();
        }
    }
}
