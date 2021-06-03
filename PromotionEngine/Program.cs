using System;
using System.Collections.Generic;
using PromotionEngine.Implementations;

namespace PromotionEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            ProductService objproductservice = new ProductService();
            Console.WriteLine("Please enter the total number of orders");
            int ordercount = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < ordercount; i++)
            {
                Console.WriteLine("Enter the product ID of type A,B,C or D");
                string id = Console.ReadLine();
                Product p = new Product();
                p.id = id;
                products.Add(p);
            }

            int totalPrice = objproductservice.GetTotalPrice(products);
            Console.WriteLine(totalPrice);
            Console.ReadLine();
        }
    }
}
