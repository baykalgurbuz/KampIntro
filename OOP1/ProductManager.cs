using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product) 
        {
            Console.WriteLine(product.ProductName+" "+"addition .");
        }
        public void Update(Product product) 
        {
            Console.WriteLine(product.ProductName+" "+"updated .");
        }
        public void Delete(Product product)
        {
            Console.WriteLine(product.ProductName+" "+"is deleting. ");
        }
     
    }
}
