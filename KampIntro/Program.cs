using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety = Tip Güvenliği
            //Do not repeat yourself = Kendini Tekrarlama
            //Değer Tutucu , Alias(Takma Ad)

            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.55;
            double dolarBugun = 7.55;


            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu Göster");

            }

            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu Göster");
            }

            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }



            if (sistemeGirisYapmisMi == true) 
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }

            Console.WriteLine(kategoriEtiketi);

            



        }
    }
}
