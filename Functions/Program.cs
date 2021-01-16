using System;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Product apple = new Product();
            apple.Name = "Kentucky";
            apple.Price = 15.1;
            apple.Id = 1;
            apple.Explanation = "Fresh fresh huhuuuuuuuuuu.";

            Product banana = new Product();
            banana.Name = "Texas";
            banana.Price = 30.2;
            banana.Id = 2;
            banana.Explanation = "Green Banana .";

            Product[] productList = new Product[] {apple,banana};

            foreach (Product bring in productList)
            {
                Console.WriteLine(bring.Name);
                Console.WriteLine(bring.Price);
                Console.WriteLine(bring.Explanation);
                Console.WriteLine("----------");
            }
            Console.WriteLine("----Methodlar----");
            BasketManager b1 = new BasketManager();
            b1.Addition(apple);

            Console.WriteLine("----Methodlar2----");
            b1.AdditionTwo("Elma","Amasya Elması");
        }
    }
}
