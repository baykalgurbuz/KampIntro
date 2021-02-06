using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "1234";
            musteri1.Adi = "Baykal";
            musteri1.Soyadi = "Gürbüz";
            musteri1.TcNo = "123124231";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "12312";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();
            MusteriManager manager = new MusteriManager();
            manager.Add(musteri1);
            manager.Add(musteri2);


        }
    }
}
