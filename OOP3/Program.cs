using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            İhtiyacKrediManager ihtiyac = new İhtiyacKrediManager();
            IKrediManager tasit = new TasitKrediManager();//İnterfeca ile de nesene olusturabilriz .İnterfacelerde referans numarasını tutabilir .
            KonutKrediManager konut = new KonutKrediManager();

            BasvuruManager basvuruManager = new BasvuruManager();
            ILoggerService database = new dateBaseLoggerService();
            ILoggerService fileLogger = new FileBaseLoggerService();
            basvuruManager.BasvuruYap(ihtiyac,database);
            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyac,tasit};
          //  basvuruManager.KrediOnBilgilendirmesiYap(krediler);

            
        }
    }
}
