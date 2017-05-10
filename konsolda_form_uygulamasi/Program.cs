using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;//using e namespace ekleniyor
namespace konsolda_form_uygulamasi
#region//console uygulamasına windows form ekleme.Bunun için refereces a System.Windows.Froms eklendi
{
     class Program
     {
        static void Main(string[] args)
        {
            MessageBox.Show("console uygulaması başlatılacak");
            ///<remarks>form penceresini çalıştırmak için, ana methodumuz olan main metodunda Program_2 class ından bir nesne oluşturduk.Böylece bu nesneyi Run() methodunun kullanarak çalıştırmamızı sağladık </remarks>  
            Console.WriteLine("Form1 penceresi açıldı");
            Program_2 Form1=new Program_2();
            ///<example>form pencerelerinin çalışmasını sağlayan Application sınıfına ait Run () methodu          Application.Run(Form1); windows form penceresini Run() metodunun dışında istenilirse Form1.ShowDialog(); metodu ile de aynı işlemi yapabiliriz</example>
            ///
            ///form penceresine listbox ekleyelim:
            ListBox liste1 = new ListBox();
            liste1.Top = 25;
            liste1.Left = 25;
            liste1.Parent = Form1;
            liste1.Items.Add("melih şahin");//listbox a ekleme yapıyoruz
            liste1.Items.Add("mehmet şahin");
            ///<remarks>form pencerelerinin çalışmasını sağlayan ShowDialog() metodu</remarks>
            Form1.ShowDialog();
            
            /// bir form penceresini ekranda göstermek için ayrıca bir -Program_2 class ı gibi- ayrı bir class tanımlamamıza gerek yoktur.main metedonun içinde de genel Form classından bir nesne üreterek de bu işlemi gerçekleştirebiliriz.
            Form form2 = new Form();
            form2.Text= "form2 başlığı";
            form2.ShowDialog();
            
           
        }
     }

#region//console sınıfımız olan Program_2 class ını.Form class ının mirasçısı olmasını sağladık.Böylece console uygulamasında form hazırlayıp ekrana getirebiliriz.
    class Program_2:Form
    {
      ///<remarks>Program_2 metodu bir Constructur(yapıcı) metottur. Yapıcı metotlar bulunduğu class ile aynı ada sahip metotlardır.Void parametresi tanımlanmamış olmasına rağmen return özelliği yoktur</remarks>
        public Program_2()
        {   //bu kod form penceresi açıldığındaki yazıyı ayarlamamıza yarar.
            this.Text = "form penceremizin yazısı";
            
        }
    }
}
#endregion
#endregion