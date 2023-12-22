using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //// Burada ekrana isimlerin hepsini yazdırır. Eğer biz tekrardan başka bir veri yazdırmak istersek ; 

            //isimler = new string[5];
            //isimler[4] = "İlker";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);

            // Burada isimler dizilerinin değerini yükselttik çünkü bizim dizilerimiz 4 değişkenliydi. Ama şöyle bir durum var biz yeni bir
            // dizi tanımladığımız için sisteme diziler de ki 0. elemanı ekrana yazdıramıycak. Çünkü üst satırda ki dizi artık iptal oldu 
            // biz yeni satır da dizi eklediğimiz için program oradan başlayacak ve 0. eleman olmadığı için ekran boş dönücek.

            // Burada ise listeler methodunu kullanarak tekrar veri ekleyeceğimiz de ekleyip istediğimiz veriden devam edebiliyoruz. 
            List<string> isimler2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
        }
    }
}
