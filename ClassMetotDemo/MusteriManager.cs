using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Person kisi)
        {
            Console.WriteLine("Kişi Eklendi! : " + kisi.Adi + " " + kisi.Soyadi);

        }

        public void Sil(Person kisi)
        {
            Console.WriteLine("Kişi Silindi! : " + kisi.Adi + " " + kisi.Soyadi);

        }


        



    }
}
