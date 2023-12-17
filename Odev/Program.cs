using System;

namespace Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun Urun1 = new Urun();
            Urun1.UrunAd = "Şampuan";
            Urun1.UrunCesidi = "Kozmetik";
            Urun1.UrunAgirligi = 1;
            Urun1.UrunRengi = "Beyaz";

            Urun Urun2 = new Urun();
            Urun2.UrunAd = "Tshirt";
            Urun2.UrunCesidi = "Giyim";
            Urun2.UrunAgirligi = 8;
            Urun2.UrunRengi = "Mor";

            Urun Urun3 = new Urun();
            Urun3.UrunAd = "Bot";
            Urun3.UrunCesidi = "Ayakkabı";
            Urun3.UrunAgirligi = 5;
            Urun3.UrunRengi = "Siyah";

            Urun[] urunler = new Urun[] { Urun1, Urun2, Urun3 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.UrunAd + " " + urun.UrunCesidi + "  "+ urun.UrunAgirligi+" "+urun.UrunRengi);
            }
            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].UrunAd);
                Console.WriteLine(urunler[i].UrunCesidi);
                Console.WriteLine(urunler[i].UrunAgirligi);
                Console.WriteLine(urunler[i].UrunRengi);
            }
        }
    }
    class Urun
    {
        public string UrunAd { get; set; }
        public string UrunCesidi { get; set; }
        public int UrunAgirligi { get; set; }
        public string UrunRengi { get; set; }
    }
}