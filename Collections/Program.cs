using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] NameList = new string[] { "Enes", "Baykal", "Beyza", "Serra" };
            //Console.WriteLine(NameList[0] + NameList[1] + NameList[2]);
            //NameList = new string[5];//Bu hareketi yaparsak üstteki string değerini bozup yeni değer yapıyoruz .Arrayde sonradan ekleme yapamıyoruz .
            //Console.WriteLine(NameList[2]);//Bış gelmesinin sebebei yukarıda yeni array oolusturmak öncekini bozmak .

            List<string> NameList2 = new List<string>() {"Enes","Baykal","Beyza","Serra"};//Arraylerin aynısını yapar fakat ekleme olanağı sağlar .
            Console.WriteLine(NameList2[0]);
            Console.WriteLine(NameList2[1]);
            Console.WriteLine(NameList2[2]);
            Console.WriteLine(NameList2[3]);
            NameList2.Add("Yusuf");
            Console.WriteLine(NameList2[4]);
        }
    }
}
