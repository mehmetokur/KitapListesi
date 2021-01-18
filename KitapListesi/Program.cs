using System;

namespace KitapListesi
{
    class Program
    {
        static void Main(string[] args)
        {
            Kitap kitap1 = new Kitap();
            kitap1.Adi = "İFA";
            kitap1.Yazari = "Sinan Canan";
            kitap1.Yayinevi = "Tuti Kitap";
            kitap1.Fiyati = 25;

            Kitap kitap2 = new Kitap();
            kitap2.Adi = "Dava";
            kitap2.Yazari = "Franz Kafka";
            kitap2.Yayinevi = "Tutku Yayınevi";
            kitap2.Fiyati = 28;

            Kitap[] kitaplar = new Kitap[] {kitap1,kitap2 };
            foreach (var kitap in kitaplar)
            {
                Console.WriteLine("Adı:"+" "+kitap.Adi);
                Console.WriteLine("Yazarı:" + " " + kitap.Yazari);
                Console.WriteLine("Yayınevi:" + " " + kitap.Yayinevi);
                Console.WriteLine("Fiyatı:" + " " +"£"+ kitap.Fiyati);
                Console.WriteLine();

            }
            Console.WriteLine("          ----------------           ");
            KitapManager kitapManager = new KitapManager();
            kitapManager.Ekle(kitap1);
            kitapManager.Ekle(kitap2);
            Console.WriteLine("          ----------------           ");
            kitapManager.Listele(kitap1);
            kitapManager.Listele(kitap2);
            Console.WriteLine("          ----------------           ");
            kitapManager.Cıkar(kitap1);
            kitapManager.Cıkar(kitap2);
        }
    }
}
