using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo1
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " İsimli müşteri eklenmiştir:)");
        }
        public void Silme(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " İsimli müşteri silinmiştir!");
        }
        public void Listeleme(Musteri[] musteri)
        {
            foreach (var x in musteri)
            {
                Console.WriteLine("Müşteri Id: "+x.Id);
                Console.WriteLine("Müşteri Adı: " + x.Adi);
                Console.WriteLine("Müşteri Sayadı: " + x.Soyadi);
                Console.WriteLine("Müşteri Kart türü: " + x.KartTuru);
                Console.WriteLine("---------------------------------------");
            }
        }
    }
}
