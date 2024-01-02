using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        // Burada başvuru yapacağımız zaman hangi kredi için işlem yapması gerektiğini bilmediğimiz için. IKrediManager ınterface in de
        // bütün kredileri topladık bu yüzden IKrediManager dan çekerek işlem yaptırıyoruz. Bu yüzden o interface i tanımlıyoruz içerisine.
       
        // method injection yani bu methodun hangi kredi türü olacağını hangi tür de loglama yapacağını enjekte ediyoruz.
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)
        {
            // Başvuran bilgilerini değerlendirme
            krediManager.Hesapla();
            loggerService.Log();
        }
        // Birden fazla kredi seçeneklerinin hesaplarını yapmak için bunu yapıyoruz. Örneğin bir müşteri kredi çekeceği zaman taşıtta ne
        // kadar ödeyeceğini ihtiyaçta ne kadar ödeyeceğini merak edebilir. O zaman biz bununla birden fazla işlem yaptırıyoruz.

        //Burada ise elimizde birden fazla kredi imkanı olduğu için List ile bütün kredileri çağırabiliyoruz. Bu yüzden List oluşturuyoruz.
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
