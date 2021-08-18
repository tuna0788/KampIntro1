using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string ururnAdi = "Elma";
            double fiyati = 15;
            string Aciklama = "Elmalı Elması";

            string[] meyve = new string[] { };

            Product urun1 = new Product();
            urun1.Adi = "Elma";
            urun1.Fiyat = 20;
            urun1.Aciklama = "Amasya Elması";

            Product urun2 = new Product();
            urun2.Adi = "Kayısı";
            urun2.Fiyat = 10;
            urun2.Aciklama = "Malatya Kayısısı";

            Product[] products = new Product[] {urun1,urun2 };

            foreach (var item in products)
            {
                Console.WriteLine(item.Adi+" Fiyatı "+item.Fiyat+" "+item.Aciklama);
                Console.WriteLine("----------------------");
            }

            Console.WriteLine("İşlem bitti");
        }
    }
}
