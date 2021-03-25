using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{
    class SepetManager
    {
        //naming convention-isimlendirme kuralı
        public void Ekle(Product urun)//Metod bir parametre alır. Parametrenin tipi Producttır.
        {
            Console.WriteLine("Sepete eklendi:" + urun.Adi);
        }

        public void Ekle2(string urunAdi,string aciklama,double fiyat)//Yeni bir parametre eklendiğinde metodun kullanıldığı tüm sayfalar hata verir.Bu yüzden kullanımı çokta doğru değildir.
        {
            Console.WriteLine("sepete eklendi:"+ urunAdi);
        }

    }
}
