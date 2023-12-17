using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yerleştirme Kampı";
            string kurs2 = "Programlamaya Başlangıç ";
            string kurs3 = "Java";
            string kurs4 = "Pyhton";
            string kurs5 = "C#";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);
            Console.WriteLine(kurs5);

            //array - dizi (Bu kursları tek bir dizi içerisin de yapmamız gerekir. Birden fazla veri olduğu için her veri de 
            //sürekli veri tanımlama ve ekrana yazdırmak için uğraşılmaz.
            Console.WriteLine("------------------ FOR DÖNGÜSÜ İLE YAPIYORUZ -------------------");
            string[] kurslar = new string[] { "Yazılım Geliştirici Yerleştirme Kampı", "Programlamaya Başlangıç ", 
                "Java", "Pyhton","C#"};
            
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("----------------- FOR DÖNGÜSÜ BİTTİ FOREACH DÖNGÜSÜ İLE YAPIYORUZ ------------------");

            //Kurslar dizimiz de oluşturduğumuz verileri tek tek ekrana verebilmemiz için for döngüsü ile i değerimizi
            //0 dan başlatarak kurslar.length yani dizi de ki son elemana kadar dönmesini sağlıyarak ne kadar kurs varsa ekrana yazdırırız.
            //** kurslar[i] burada ise böyle yazmamızın sebebi kurslar dizisinde ki i. elemanın da başlamasını istediğimiz için 
            //sadece i yazmış olsaydık kursun içinde ki veri kadar döngü dönecekti ve sadece ekrana sayı yazacaktı. 

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            // ** foreach in içinde ki kodlar ise ilk başta ki string dizimizin türü öyle olduğu için kurs ise bizim verdiğimiz her hangi bir isim
            // ve in kurslar ise hazırlamış olduğumuz dizimizin değişken ismi o olduğu için 
            // Bu tarz diziler de for yerine foreach kullanmak daha mantıklı çünkü yazmış olduğumuz dizi de foreach döngüsü tek tek 
            // dolaşarak ekrana vermesi daha kolay olduğu için. 
        }
    }
}
