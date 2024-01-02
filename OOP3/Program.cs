using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            // İnterfaceler de o interface i inplemente eden class ın referans numarasını tutabiliyormuş.

            IKrediManager ihtiyacKrediManager = new İhtiyacKrediManager();          
            IKrediManager konutKrediManager = new KonutKrediManager();           
            IKrediManager tasitKrediManager = new TasitKrediManager();
           
            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            
            // Biz artık başvuruyap için log servisini de eklediğimiz için basvurumanager da çağırırken ikisini de çağırmamız lazım.
            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyacKrediManager, databaseLoggerService);

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager};
            
            // Yukarda newlediğimiz basvurumanagerın içinde ki KrediOnBilgilendirmesi methodunu çağırıyoruz ve krediler adı altında oluşturalan
            // list te ki krediler dönüyor.

           // basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
