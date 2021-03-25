using System;

namespace Metodlar
{
    class Program
    {
        //Metodlar bize tekrar tekrar aynı şeyi kullanabilme imkanı verir.
        //encapsulation-kapsülleme
        static void Main(string[] args)
        {
            Product urun1 = new Product();//bir class tanımlamak için bu işlemi yapmam gerekir.Product tipinde urun1;
            urun1.Adi = "Elma";
            urun1.Fiyati =15;
            urun1.Aciklama = "Amasya Elması";

            Product urun2 = new Product();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Product[] urunler = new Product[] {urun1,urun2};//Product türünde urunler adında bir array oluşturduk.

            foreach (Product urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-----------------------");

            }

                Console.WriteLine("-----------Metodlar------------");
                SepetManager sepetManager = new SepetManager();
                sepetManager.Ekle(urun1);
                sepetManager.Ekle2("Elma", "Amasya Elması", 12);


        }
    }
}
