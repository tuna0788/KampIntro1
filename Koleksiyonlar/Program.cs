using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[]{ "Tuna", "Kazım", "Serdar", "Ramazan" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            ////isimler[4] = "Mehmet";
            ////Console.WriteLine(isimler[4]);

            List<string> isimler2 = new List<string>();
            isimler2.Add("Ali");
            isimler2.Add("Veli");
            isimler2.Add("Musa");
            Console.WriteLine(isimler2[2]);
            isimler2.Add("Kazım");
            Console.WriteLine(isimler2[3]);
            Console.WriteLine(isimler2[0]);
        }
    }
}
