using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Person kisi1 = new Person();
            kisi1.Id = "123456";
            kisi1.Adi = "Ege";
            kisi1.Soyadi = "Özman";
            kisi1.Yaşi = "20";

            Person kisi2 = new Person();
            kisi2.Id = "123457";
            kisi2.Adi = "Engin";
            kisi2.Soyadi = "Demir";
            kisi2.Yaşi = "35";

            Person kisi3 = new Person();
            kisi3.Id = "123458";
            kisi3.Adi = "Cem";
            kisi3.Soyadi = "Kücük";
            kisi3.Yaşi = "42";

            Person[] kisiler = new Person[] { kisi1, kisi2, kisi3, };

            foreach (var liste in kisiler)
            {
                Console.WriteLine(liste.Id + " : " + liste.Adi);
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(kisi1);
            musteriManager.Sil(kisi2);





        }
    }



    class Person
    {
        public string Id { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Yaşi { get; set; }


    }




}
