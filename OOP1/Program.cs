using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product();
            p1.Id = 1;           
            p1.ProductName = "Desk";
            p1.CategoryId = 2;
            p1.UnitPrice = 500;
            p1.UnitsInStock = 3;

            Product p2 = new Product { Id = 1, ProductName = "Pen", UnitPrice = 35, UnitsInStock = 5, CategoryId = 5 };

            ProductManager productmanager = new ProductManager();
         
        }
    }
}
