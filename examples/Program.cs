
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examples
{
    class Ogrenci
    {
        public string ad,soyad;
        public int yas;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogr1 = new Ogrenci();

            ogr1.ad = "ali";
            ogr1.soyad = "bilmiş";
            ogr1.yas = 13;

            Ogrenci ogr2 = new Ogrenci();
            ogr2 = ogr1;
            ogr2.ad = "mehmet";
            ogr2.soyad = "kartal";
            ogr2.yas = 5;
            object referans_tip = 14;
            int deger_tip = (int)referans_tip;
            object tekrar = deger_tip;

            Console.WriteLine(tekrar);
            Console.ReadLine();
        }
    }
}
