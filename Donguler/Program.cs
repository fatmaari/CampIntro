using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Döngüler:Birbirine benzeyen işlemlerin tekrar edilmesi için kullanılır.

            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya Başlangıç Kampı";        
            string kurs3 = "Java";

            //array-dizi

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya Başlangıç Kampı", "Java","Pyhton" };

            foreach (var kurs in kurslar)//dizi temelli yapıları tek tek dönmeye yarar.
            {
                Console.WriteLine(kurs);
            }

            for (int i = 0; i<kurslar.Length; i++)//daha genel amaçlar için kullanılır.
            {
                Console.WriteLine(kurslar[i]);

            }
        }
    }
}
