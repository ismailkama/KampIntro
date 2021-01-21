using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "İsmail";
            int yas = 22;

            Kurs kurs1=new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.KursunEgitmeni = "Engin";
            kurs1.İzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.KursunEgitmeni = "Kerem";
            kurs2.İzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.KursunEgitmeni = "Berkay";
            kurs3.İzlenmeOrani = 80;


            // Console.WriteLine(kurs1.KursAdi + " : " + kurs1.KursunEgitmeni);


            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 };

            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi);
            }


            //Console.WriteLine("Hello World!");
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string KursunEgitmeni { get; set; }
        public int İzlenmeOrani { get; set; }


    }
}
