using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_stringBuilderSinifiOrnek
{
    class Program
    {
        private const int gizlenecekCharAdedi = 3;
        static void Main(string[] args)
        {
            //girilen bir metinde belirlediğimiz karakterlerin değiştirilmesi örnek çalışma
            ///<see cref="http://www.ahmetcansever.com/programlama/c-girilen-metinde-istenilen-karakterleri-degistirme/"/>
            ///StringBuilder sınıfı açıklama
            ///<see cref="http://www.gencayyildiz.com/blog/cta-stringbuilder-sinifi/"/>
            Console.WriteLine("girilen bir metinde belirlediğimiz karakterlerin  değiştirilmesi");
            Console.WriteLine("********************************************************");
            Console.Write("bir metin girin: ");
            string metin = Console.ReadLine();
            StringBuilder sb = new StringBuilder(metin);

            ///<summary>
            ///  if (i>=metin.Length-(metin.Length-gizlenecekCharAdedi))
            ///  koşulu ile girilen metinin daima ilk 3 karakteri gösterilip geri kalan * karakteriyle kapatılacaktır
            ///</summary>
            for (int i = 0; i <metin.Length; i++)
            {
                if (i>=metin.Length-(metin.Length-gizlenecekCharAdedi))
                {
                    sb[i] = '*';
                }
            }
            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
