using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Aykut", "Bila", "Beyza", "Bebej" };
            ////Console.WriteLine(0);
            ////Console.WriteLine(1);
            ////Console.WriteLine(2);
            ////Console.WriteLine(3);

            ////isimler = new string[5];
            ////isimler[4] = "Ilker";
            ////Console.WriteLine(4);
            ////Console.WriteLine(5);

            List<string> isimler2 = new List<string> {"aykut","bilo","beyzo","bebej2"};
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Ilker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);


        }
    }
}