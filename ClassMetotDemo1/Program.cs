using System;

namespace ClassMetotDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Yeşim";
            musteri1.Soyadi = "Köse";
            musteri1.KartTuru = "Banka Kartı";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Aynur";
            musteri2.Soyadi = "Köse";
            musteri2.KartTuru = "Kredi Kartı";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Adi = "Gülsün";
            musteri3.Soyadi = "Köse";
            musteri3.KartTuru = "Banka Kartı";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            Console.WriteLine("----------------------------------");
            musteriManager.Listeleme(musteriler);
            musteriManager.Silme(musteri1);
        }
    }
}
