using System;
using System.Collections.Generic;
using System.Text;
using PromotionEngine.Interfaces;

namespace PromotionEngine.Implementations
{
    class ProductService : IProductInterface
    {
        public int GetPriceByType(string productid)
        {
            int price = 0;
            switch (productid)
            {
                case "A":
                    price = 50;

                    break;
                case "B":
                    price = 30;

                    break;
                case "C":
                    price = 20;

                    break;
                case "D":
                    price = 15;
                    break;
            }
            return price;
        }

        public int GetTotalPrice(List<Product> products)
        {
            int countA = 0;
            int countB = 0;
            int countC = 0;
            int countD = 0;
            return 0;
        }
    }
}
