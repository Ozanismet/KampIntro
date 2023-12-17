using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Muz";
            urun1.Fiyati = 35;
            urun1.Aciklama = "Yerli Muz";


            Urun urun2 = new Urun();
            urun2.Adi = "Portakal";
            urun2.Fiyati = 17;
            urun2.Aciklama = "Antalya Portakalı";

            Urun urun3 = new Urun();
            urun3.Adi = "Nar";
            urun3.Fiyati = 28;
            urun3.Aciklama = "Ekşi Nar";

            Urun[] urunler = new Urun[] { urun1, urun2,urun3 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);

            }
            Console.WriteLine("----------------- Metotlar ---------------------");

            // instance = Class örneği oluşturmaya denilir.
            // encapsulation = İlişkilendirme

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle(urun3);

            sepetManager.Ekle2("Elma", "Adana ", 15);
            sepetManager.Ekle2("Kiraz", "Afyon ", 15);
            sepetManager.Ekle2("Armut", "Bursa ", 15);


        }
    }
}
