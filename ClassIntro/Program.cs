using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 0;
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "Yazilim Kampi";
            kurs1.KursEgitmen = "Engin Demiroğ";
            kurs1.KursİzlenmeOran = 54;
            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Cyber Security Camp";
            kurs2.KursEgitmen = "Atıl Samancıoğlu";
            kurs2.KursİzlenmeOran = 74;


            Kurs[] kurslarimiz = new Kurs[] {kurs1,kurs2 };

            foreach (Kurs kursgetir in kurslarimiz)
            {
                Console.WriteLine("List with foreach");
                Console.WriteLine(kursgetir.KursAdi);
                Console.WriteLine(kursgetir.KursEgitmen);
                Console.WriteLine(kursgetir.KursİzlenmeOran);
                Console.WriteLine("-------------------");
            }
            for(int i=0;i<kurslarimiz.Length;i++)
            {
                Console.WriteLine("List with for");
                Console.WriteLine(kurslarimiz[i].KursAdi);
                Console.WriteLine(kurslarimiz[i].KursEgitmen);
                Console.WriteLine(kurslarimiz[i].KursİzlenmeOran);
                Console.WriteLine("------------------------");
            }
            
            while (k< kurslarimiz.Length)
            {
                Console.WriteLine("List with while");
                Console.WriteLine(kurslarimiz[k].KursAdi);
                Console.WriteLine(kurslarimiz[k].KursEgitmen);
                Console.WriteLine(kurslarimiz[k].KursİzlenmeOran);
                k++;
                Console.WriteLine("------------------------");
            }
        }
    }
    class Kurs 
    {
        public string KursAdi { get; set; }

        public string KursEgitmen { get; set; }

        public int KursİzlenmeOran { get; set; }

    }
}
