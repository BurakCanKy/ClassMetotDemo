using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine(musteri.ID + " " + musteri.isim + " " + musteri.yas +" Bilgileri Eklenmiştir.");
        }
        public void MusteriListeleme(Musteri musteri)
        {
            Console.WriteLine(musteri.ID + " " + musteri.isim + " " + musteri.yas + " Bilgileri Listelenmiştir.");
        }
        public void MusteriSilme(Musteri musteri)
        {
            Console.WriteLine(musteri.ID + " " + musteri.isim + " " + musteri.yas + " Bilgileri Silinmiştir.");
        }
    }
}
