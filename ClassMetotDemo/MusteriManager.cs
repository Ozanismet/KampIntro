using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad+ " İsimli müşteri sisteme eklendi. ");
        }
        public void Listeleme(Musteri musteri)
        {
            Console.WriteLine(musteri.Id+ " " + musteri.Ad+ " "+ musteri.Soyad+ " "+ musteri.Yas);
        }
        public void Silme(Musteri musteri)
        {
            Console.WriteLine(musteri.Id+ " numaralı kişi sistemden silinmiştir.");
        }
    }
}
