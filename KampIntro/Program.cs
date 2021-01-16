using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            string kategoriAdi = "C# Dersleri ";
            Console.WriteLine(kategoriAdi);
            bool kayitlimidegilmi = true;
          //  double faiz = 1.45;
            double dolardun = 7.45;
            double dolarbugun = 7.56;

            if (dolardun>dolarbugun)
            {
                Console.WriteLine("dolar düstü");
            }
            else if(dolardun<dolarbugun) 
            {
                Console.WriteLine("dolar arttı");
            }
            else
            {
                Console.WriteLine("eşit");
            }
            if (kayitlimidegilmi==true)
            {
                Console.WriteLine("Sisteme hoşgeldiniz ...");
            }
            else
            {
                Console.WriteLine("Sisteme giriş yapınız .");
            }
        }
    }
}
