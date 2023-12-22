using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 179;
            musteri1.Ad = "Ozan";
            musteri1.Soyad = "Alyörük";
            musteri1.Yas = 26;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 248;
            musteri2.Ad = "Ali";
            musteri2.Soyad = "Veli";
            musteri2.Yas = 28;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 364;
            musteri3.Ad = "Mehmet";
            musteri3.Soyad = "Bulut";
            musteri3.Yas = 45;

            Musteri musteri4 = new Musteri();
            musteri4.Id = 125;
            musteri4.Ad = "Berk";
            musteri4.Soyad = "Can";
            musteri4.Yas = 37;


            Musteri musteri5 = new Musteri();
            musteri5.Id = 857;
            musteri5.Ad = "Tarık";
            musteri5.Soyad = "Akan";
            musteri5.Yas = 56;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4, musteri5 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Id+ " : " + musteri.Ad+ " " + musteri.Soyad+ " " + musteri.Yas+ " Yaşındasınız. " );
                
            }
            Console.WriteLine("----------------------------------------------------------------------------");
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);
            musteriManager.Ekle(musteri5);

            Console.WriteLine("--------LİSTELEME---------");

            musteriManager.Listeleme(musteri1);
            musteriManager.Listeleme(musteri2);
            musteriManager.Listeleme(musteri3);
            musteriManager.Listeleme(musteri4);
            musteriManager.Listeleme(musteri5);

            Console.WriteLine("----------SİLME----------");

            musteriManager.Silme(musteri1);
            musteriManager.Silme(musteri2);
        }
    }
}
