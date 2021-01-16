using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i+" # \n");
            }
            string[] kurslarimiz = new string []{"C#","Python","Java","React","Javascript","C","C++"};

            for (int i = 0; i < kurslarimiz.Length; i++)
            {
                Console.WriteLine(kurslarimiz[i]);
            }
            foreach (string getir in kurslarimiz)
            {
                Console.WriteLine("Foreach "+getir);
            }
        }
    }
}
