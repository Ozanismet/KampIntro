using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriId = 1;
            musteri1.MusteriNo = "12345";
            musteri1.MusteriAdı = "Ozan";
            musteri1.MusteriSoyadı = "Alyörük";
            musteri1.TcNo = "123456789";

            // Kodlama.io şirketi için yapalım. 

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.MusteriId = 2;
            musteri2.MusteriNo = "23456";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "58749856";

            // Burada Musteri classı ile diğer classlara veri oluşturabildik. Musteri class ı hem GercekMusteri referansını hem de TuzelMusteri
            // referansını tutabiliyor. 
            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
             
        }
    }
}
