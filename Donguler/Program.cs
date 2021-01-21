using System;

namespace Donguler
{
    class Program
    {

        // Döngüler birbirine benzeyen işlemleri tekrar etmek için kullanırız. 
        // i++ veya i=i+1 >> 1 er arttır.
        // i+=2 veya i=i+2 >> 2 şer arttır.
        // i+=3 veya i=i+3 >> 3 er arttır.

        static void Main(string[] args)
        {

            string kurs1 = "Yazılım Geliştirici Kampı";
            string kurs2 = "Programlamaya Başlangıç İçin Temel Kurs";
            string kurs3 = "Java Kursu";
            string kurs4 = "Python";

            //Kursları her defasında kurs5 , kurs6 , kurs7 ........ ifadesiyle tek tek yazmak yerine Array(Dizi) kullanılır.

            string[] kurslar = new string[] { "Yazılım Geliştirici Kampı", "Programlamaya Başlangıç İçin Temel Kurs" , "Java Kursu" };


            for (int i=0; i<kurslar.Length; i++)   // kurslar.Length >> Kursların Dizisindeki Eleman Uzunluğu Kadar
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For Bitti"); 



            foreach (string kurs in kurslar)  // Dizi temelli yapıları tek tek dönmeye yarar. Dizilere uygulanır.
            {
                Console.WriteLine(kurs);
            }

            // For ile Foreach aynı şeyleri döndürdü.


            Console.WriteLine("Sayfa Sonu - Footer");
        }
    }
}
