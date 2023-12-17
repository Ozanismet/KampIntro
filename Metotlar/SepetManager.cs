using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        // syntax : Yazım Şekili 
        // Parametreler : Bu metho da neyi eklemek istediğimiz parametre kullanarak ekliyoruz. 
        // public void Ekle( Urun urun) Burda yapılan işlem Urun isimli oluşturduğumuz tipte ki istediğimiz verileri urun değişken ismi 
        // vererek o isimi kullanarak çekiyoruz. 
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete Eklendi : " +  urun.Adi);
            
        }
        // Biz class ı bu şekilde de tanımlayabiliriz. Yukarı da Urun sınıfın dan çekip kullanıyorduk burada kendimiz parametre ile yapıyoruz. 
        // Ama bunun şöyle bir sorunu var biz bu veri için tek tek parametrelerin hepsinin bilgilerini vermemiz lazım ki çalışabilsin. 
        // Sonradan Ekle2 classa başka bir özellik gelirse bütün yazılan kodlara tekrar o yeni bilgiyi girmemiz gerekiyor bu yüzden tercih etmiyoruz bu halini.
        public void Ekle2(string urunAdi, string aciklama, double fiyat)
        {
            Console.WriteLine("Sepete Eklendi : " + urunAdi);
        }
    }
}
