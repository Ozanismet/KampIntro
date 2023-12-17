using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            // sayi1 ? 

            // Bu bir değer tipi olduğu için sistem şöyle ilerliyor. Değerler tanımlanmış ve sayi1 in değeri sayi nin değerine atanıyor.
            // Bu durum da sayi 1 ve sayi 2 nin değeri 30 olur sonrasın da sayi2 nin değeri farklı veriliyor.  Yani sonuç 30 olur. 

            int[] sayilar1 = new int[] {10,20,30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0] ? 

            // Array olduğu için bu referans tipi farklı çalışıyor. Stack kısmında sayilar1 oluşuyor ve heap kısmın da ise sayilar1 in değerleri bulunuyor.
            // Bu değerler adres ile tutuluyor (defter de yazıldı) yine sayilar1 sayilar2 ye eşitleniyor ve sayilar1 de ki değerler ile işimiz kalmıyor.
            // sayilar1 in değerleri de (100 200 300) oluyor. Sonrasın da sayilar2 de ki ilk değer 999 tanımlandığı için sayilar2 adresinin son hali 
            // {999, 200, 300} bu durum da sayilar1 in adresi sayilar2 ye tanımlandığı için sayilar1 in değeri ise 999 oluyor. 
        }
    }
}
