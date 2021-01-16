using System;
using System.Collections.Generic;
using System.Text;

namespace Functions
{
    class BasketManager
    {
        //conversion - isimlendirme kuralı
        public void Addition(Product product)
        {
            Console.WriteLine("Sepete Eklendi ."+product.Name);
        }
        public void AdditionTwo(string Name,string Explanatione)
        {
            Console.WriteLine("Eklenen verinin adi  :" +Name);
        }
    }
}
