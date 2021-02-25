using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            musteri musteri1 = new musteri();
            musteri1.Adi = "Melek";
            musteri1.Soyadi = "nur";
            musteri1.yasi  = 25;

            musteri musteri2 = new musteri();
            musteri2.Adi = "Fatih";
            musteri2.Soyadi = "güz";
            musteri2.yasi = 30;

            musteri musteri3 = new musteri ();
            musteri3.Adi = "Buse";
            musteri3.Soyadi = "gül";
            musteri3.yasi = 18;

            musteri[] musteriler = new musteri[] { musteri1, musteri2, musteri3 };

            foreach (musteri  musteri in musteriler)
            {
                Console.WriteLine(musteri .Adi);
                Console.WriteLine(musteri.Soyadi );
                Console.WriteLine(musteri .yasi );
                Console.WriteLine("----------------------");
            }


            MusteriManager musteriManager = new MusteriManager () ;
            musteriManager.Ekle(musteri2);            
            musteriManager.Sil(musteri1 );         
            musteriManager.Listele (musteri3);


        }
    }
}
