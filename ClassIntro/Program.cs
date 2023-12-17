using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Burada Kurs sınıfın da oluşturduğumuz sınıfın içerisine değişkenler tanımlayarak dolduruyoruz.
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 65;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Ozan Alyörük";
            kurs2.IzlenmeOrani = 84;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Pyhton";
            kurs3.Egitmen = "Engin Çelik";
            kurs3.IzlenmeOrani = 78;

            // Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);
            // Oluşturduğumuz değişkenleri array ile tek bir satır da toplayıp döngü kullanarak tek tek çekiyoruz.İlk başta ki kurs ise oluşturduğumuz nesne

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };
            // kurs olarak yazdığımız yer takma isim olarak veriyoruz.
            foreach (var kurs in kurslar)
            {
                //Burada ise kurs.KursAdi yazan alan da kurs yazan foreach de ki verdiğimiz isim onunle ekrana yazdırtıyoruz. Diğeri ise kurslar arrayin
                // de ki alana gidip onun içerisinde tanımlamış olduğumuz değişkenler de ki bilginin hangisini yazması gerektiğini seçiyoruz. 
                Console.WriteLine(kurs.KursAdi+ "   :    "+ kurs.Egitmen+ "     "+ kurs.IzlenmeOrani);
            }
        }
    }
    //Burada ilk önce Kurs diye bir sınıf oluşturuyoruz. Bu kurs içerisin de olması gereken bilgileri ekleyerek sonrasın da bilgileri dolduruyoruz.
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }  
    }
}
