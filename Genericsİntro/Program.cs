using Genericsİntro;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Mylist<string> isimler = new Mylist();
            isimler.Add("Aykut");

            List <string> liste = new List<string>();
            Console.WriteLine(liste.Count);

            Console.WriteLine("HW");


        }
    }
}