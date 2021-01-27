using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"Engin","Murat","Kerem","Halil"};
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]); 
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            ////new deyince ekranda yeni bi bellek açılır.
            //isimler = new string[5];
            //isimler[4] = "İlker";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);  //çalıştırdığımızda boş olarak çaliışıcaktır,çünkü yeni bi new tanımlayınca yeni bi bellek açılır.

            // Örneğin 4 elemanlı bir array tanımladığımızda onu artık 5 elemanlı yapamıyoruz , yapılır ancak eski elemanlar kaybedilir.
            //(Arraylerdeki sabitlik)

            List<string> isimler2 = new List<string> {"Engin","Murat","Kerem","Halil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
            
        }
    }
}
