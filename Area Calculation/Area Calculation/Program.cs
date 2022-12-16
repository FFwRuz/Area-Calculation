using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("          ÖRNEKLER   ");
            Console.WriteLine("");
            Console.WriteLine("____________________________");
            Console.WriteLine("Dikdörtgen İçin (1) , Üçgen İçin (2) , Daire İçin (3) , Kare için (4) 'ü Seçiniz.");
            int secim = Convert.ToInt32(Console.ReadLine());
            if(secim == 1)
            {
                d();
            }
            else if(secim == 2)
            {
                u();
            }
            else if(secim == 3)
            {
                da();
            }
            else if(secim == 4)
            {
                k();
            }
            else if(secim > 4)
            {
                Console.WriteLine("Bilinmeyen Karakter Girişi.");
            }
            Console.ReadKey();
        }
        static void d()
        {
            Console.WriteLine("Uzun Kenarı Giriniz: " + "");
            int uzunKenar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kısa Kenarı Giriniz: " + "");
            int kısaKenar = Convert.ToInt32(Console.ReadLine());
            int genel = uzunKenar * kısaKenar;
            Console.WriteLine("Toplam Alan: " + genel);
            Console.ReadKey();
        }
        static void u()
        {
            Console.WriteLine("Üçgenin Tabanını Giriniz: " + "");
            int taban = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Üçgenin Yüksekliğini Giriniz: " + "");
            int yükseklik = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Üçgenin Alanı: " + "" + (yükseklik * taban) / 2);
        }
        static void da()
        {
            Console.WriteLine("Yarı Çapı Giriniz: " + "");
            int yari = Convert.ToInt32(Console.ReadLine());
            int pi = 3;
            int cevre = 2 * pi * yari;
            int alan = pi * yari * yari;
            Console.WriteLine("Çevre: " + cevre + "Alanı: " + alan);
        }
        static void k()
        {
            int kareAlan, kenar, kareCevre;
            Console.WriteLine("Karenin Kenarını Giriniz: ");
            kenar = Convert.ToInt32(Console.ReadLine());
            kareAlan = kenar * kenar;
            kareCevre = kenar * 4;
            Console.WriteLine("Kare Alan: " +kareAlan + "Çevresi:  "+ kareCevre);
        }
    }
}
