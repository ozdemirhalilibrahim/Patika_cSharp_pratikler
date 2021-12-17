﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hazir_metotlar_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz CSharp hoşgeldiniz!";
            string degisken2 = "Csharp";

            //Lenght
            Console.WriteLine(degisken.Length);

            //TouUpper , ToLower
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());


            //Concat
            Console.WriteLine(String.Concat(degisken," Merhaba"));

            //Compare , CompareTo 
            Console.WriteLine(degisken.CompareTo(degisken2));
            Console.WriteLine(string.Compare(degisken,degisken2,true));
            Console.WriteLine(String.Compare(degisken, degisken2, false));

            //Contains
            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine(degisken.EndsWith("hoşgeldiniz"));
            Console.WriteLine(degisken.StartsWith("Merhaba"));

            //IndexOf
            Console.WriteLine(degisken.IndexOf("CS"));
            Console.WriteLine(degisken.IndexOf("Halil"));
            Console.WriteLine(degisken.LastIndexOf("i"));

            //Insert 
            Console.WriteLine(degisken.Insert(0,"Merhaba! "));

            //PadLeft , PadRight 
            Console.WriteLine(degisken + degisken2.PadLeft(30));
            Console.WriteLine(degisken + degisken2.PadLeft(30, '*'));
            Console.WriteLine(degisken.PadRight(50) + degisken2);
            Console.WriteLine(degisken.PadRight(50,'-')+degisken2);
            //Remove 
            Console.WriteLine(degisken.Remove(10));
            Console.WriteLine(degisken.Remove(5,2));
            Console.WriteLine(degisken.Remove(0, 1));

            //Replace
            Console.WriteLine(degisken.Replace("CSharp","C#"));
            Console.WriteLine(degisken.Replace(" ", "*"));

            //Split
            Console.WriteLine(degisken.Split(' ')[1]);

            //Substring

            Console.WriteLine(degisken.Substring(4));
            Console.WriteLine(degisken.Substring(4,1));


            Console.ReadLine();




        }
    }
}
