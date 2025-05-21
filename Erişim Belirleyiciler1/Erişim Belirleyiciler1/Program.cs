using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erişim_Belirleyiciler1
{
    internal class Program
    {
        class Kisi
        {
            public string Ad;              // Her yerden erişilebilir
            private string TCKimlikNo;     // Sadece sınıf içinden erişilebilir
            protected int Yas;             // Türeyen sınıflardan erişilebilir
            internal string Sehir;         // Aynı projedeki her sınıftan erişilebilir

            public Kisi(string ad, string tc, int yas, string sehir)
            {
                Ad = ad;
                TCKimlikNo = tc;
                Yas = yas;
                Sehir = sehir;
            }

            public void BilgileriYazdir()
            {
                Console.WriteLine($"Ad: {Ad}, TC: {TCKimlikNo}, Yaş: {Yas}, Şehir: {Sehir}");
            }
        }
        static void Main(string[] args)
        {
            Kisi k1 = new Kisi("Ayşe", "12345678901", 30, "İstanbul");
            k1.BilgileriYazdir();

            Console.WriteLine($"Ad: {k1.Ad}");
            Console.WriteLine($"Şehir: {k1.Sehir}");

            // k1.TCKimlikNo → private olduğu için erişilemez
            // k1.Yas → protected olduğu için burada erişilemez
        }
    }
}
