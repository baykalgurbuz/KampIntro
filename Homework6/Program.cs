using System;

namespace Homework6
{
    class Program
    {
        static void Main(string[] args)
        {
            Production Product1 = new Production();
            Product1.ProductName = "Casper";
            Product1.ProductYear = 2016;
            Product1.ProductColor = "Green";
            Product1.ProductAvailable = true;


            Production Product2 = new Production();
            Product2.ProductName = "Lenova";
            Product2.ProductYear = 2011;
            Product2.ProductColor = "Black";
            Product2.ProductAvailable = true;



            Production Product3 = new Production();
            Product3.ProductName = "Mac";
            Product3.ProductYear = 2010;
            Product3.ProductColor = "White";
            Product3.ProductAvailable = false;


            Production[] listProduct = new Production[] {Product1,Product2,Product3};


           

            foreach  (Production foreachBring  in listProduct)
            {
                Console.WriteLine("List with foreach " + " " + foreachBring.ProductName);
                Console.WriteLine("List with foreach " + " " + foreachBring.ProductYear);
                Console.WriteLine("List with foreach " + " " + foreachBring.ProductColor);
                Console.WriteLine("List with foreach " + " " + foreachBring.ProductAvailable);
                Console.WriteLine("-------------------------------------------------");
            }
            for (int i = 0; i <= listProduct.Length; i++)
            {
                Console.WriteLine("List with for " + " " + listProduct[i].ProductName);
                Console.WriteLine("List with for " + " " + listProduct[i].ProductYear);
                Console.WriteLine("List with for " + " " + listProduct[i].ProductColor);
                Console.WriteLine("List with for " + " " + listProduct[i].ProductAvailable);
                Console.WriteLine("-------------------------------------------------");

            }





        }
    }
    public class Production
    {
        public string ProductName { get; set; }
        public int ProductYear { get; set; }
        public  string ProductColor { get; set; }
        public bool ProductAvailable { get; set; }

    }
}
