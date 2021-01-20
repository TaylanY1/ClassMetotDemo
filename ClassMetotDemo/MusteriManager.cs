using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri) 
        {
            Console.WriteLine("--- Musteri Eklendi ---");
            Console.WriteLine("Musteri Id : " + musteri.Id );
            Console.WriteLine("Adi : " + musteri.MusteriAdi);
            Console.WriteLine("Soyadi : " + musteri.MusteriSoyadi);
            Console.WriteLine("Yas : " + musteri.MusteriYas);
        
        
        }
        public void Listele(Musteri musteri)
        {
            Console.WriteLine("--- Musteri Listesi ---");
            Console.WriteLine("Musteri Id : " + musteri.Id);
            Console.WriteLine("Adi : " + musteri.MusteriAdi);
            Console.WriteLine("Soyadi : " + musteri.MusteriSoyadi);
            Console.WriteLine("Yas : " + musteri.MusteriYas);
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("--- Musteri Silindi ---");
            Console.WriteLine("Musteri Id : " + musteri.Id);
            Console.WriteLine("Adi : " + musteri.MusteriAdi);
            Console.WriteLine("Soyadi : " + musteri.MusteriSoyadi);
            Console.WriteLine("Yas : " + musteri.MusteriYas);
        }

    }
}
