using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 111;
            musteri1.MusteriAdi = "Ali";
            musteri1.MusteriSoyadi = "Birinci";
            musteri1.MusteriYas = 65;


            Musteri musteri2 = new Musteri();
            musteri2.Id = 222;
            musteri2.MusteriAdi = "Veli";
            musteri2.MusteriSoyadi = "ikinci";
            musteri2.MusteriYas = 66;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 333;
            musteri3.MusteriAdi = "Ayse";
            musteri3.MusteriSoyadi = "ucuncu";
            musteri3.MusteriYas = 67;

            Musteri musteri4 = new Musteri();
            musteri4.Id = 444;
            musteri4.MusteriAdi = "Fatma";
            musteri4.MusteriSoyadi = "Dorduncu";
            musteri4.MusteriYas = 68;

            Musteri[] musteriler = new Musteri [] { musteri1, musteri2, musteri3, musteri4 };


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Listele(musteri4);
            musteriManager.Listele(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Sil(musteri1);


        }
    }
}
