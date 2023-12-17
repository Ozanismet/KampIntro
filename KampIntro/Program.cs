using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // type safety = Tip Güvenliği 
            string kategoriEtiketi = "Kategori ";

            int ogrenciSayisi = 100;

            double faizOrani = 1.45;

            bool sistemeGirisYapmisMi = true;

            double dolarDun = 33.0;
            double dolarBugun = 38.0;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalmıştır");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artmıştır");
            }
            if (dolarDun==dolarBugun)
            {
                Console.WriteLine("Değişim Yoktur");

            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarlar butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }



        }
    }
}
