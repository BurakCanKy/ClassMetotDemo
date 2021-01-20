using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri mstr1 = new Musteri();

            mstr1.ID = 1000;
            mstr1.isim = "Burak";
            mstr1.yas = 18;

            Musteri mstr2 = new Musteri();

            mstr2.ID = 2000;
            mstr2.isim = "Can";
            mstr2.yas = 18;

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(mstr1);
            musteriManager.MusteriEkle(mstr2);
            musteriManager.MusteriListeleme(mstr1);
            musteriManager.MusteriSilme(mstr2);

        }
    }
}
