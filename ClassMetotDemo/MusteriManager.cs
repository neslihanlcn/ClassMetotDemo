using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(musteri musteri )
        {
            Console.WriteLine("müşteri eklendi : " + musteri.Adi + " - " + musteri .Soyadi + " - " + musteri .yasi   );
            
        }
        public void Sil (musteri musteri)
        {
            Console.WriteLine(" müşteri silindi : "+ musteri.Adi + " - " + musteri.Soyadi + " - " + musteri.yasi);
        }

        public void Listele(musteri musteri)
        {

            Console.WriteLine(" müşteri listelendi : " + musteri.Adi + " - " + musteri.Soyadi + " - " + musteri.yasi);
        }

    }
}
