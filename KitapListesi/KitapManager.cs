using System;
using System.Collections.Generic;
using System.Text;

namespace KitapListesi
{
    class KitapManager
    {
        public void Ekle(Kitap kitap)
        {
            Console.WriteLine("Kitap eklendi."+" "+ kitap.Adi+" "+kitap.Yazari+" "+kitap.Yayinevi+" "+kitap.Fiyati);
        }
        public void Cıkar(Kitap kitap)
        {
            Console.WriteLine("Kitap çıkarıldı." + " " + kitap.Adi + " " + kitap.Yazari + " " + kitap.Yayinevi + " " + kitap.Fiyati);
        }
        public void Listele(Kitap kitap)
        {
            Console.WriteLine("Kitap listesi." + " " + kitap.Adi + " " + kitap.Yazari + " " + kitap.Yayinevi + " " + kitap.Fiyati);
        }

    }
}
