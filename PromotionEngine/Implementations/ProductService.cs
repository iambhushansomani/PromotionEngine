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
            int price=0;
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

            foreach (Product product in products)
            {
                if (product.id == "A" || product.id == "a")
                {
                    countA = countA + 1;
                }
                if (product.id == "B" || product.id == "b")
                {
                    countB = countB + 1;
                }
                if (product.id == "C" || product.id == "c")
                {
                    countC = countC + 1;
                }
                if (product.id == "D" || product.id == "d")
                {
                    countD = countD + 1;
                }
            }
            Product objProduct = new Product();
            int totalpriceofA = (countA / 3) * 130 + (countA % 3 * GetPriceByType("A"));
            int totalpriceofB = (countB / 2) * 45 + (countB % 2 * GetPriceByType("B"));
            int totalpriceofC=0;
            int totalpriceofD = 0;
            if (countD == 0)
            {
                totalpriceofC = (countC * GetPriceByType("C"));
            }
            else {
                if(countC>countD)
                { 
                totalpriceofC = ((countC-countD) * GetPriceByType("C"));
                totalpriceofD = (countD * 30);
                }
                if(countC == countD)
                    totalpriceofD = (countD * 30);
                if (countC < countD)
                {
                    totalpriceofD = ((countD - countC) * GetPriceByType("D"));
                    totalpriceofC = (countC * 30);
                }
            }
            

            return (totalpriceofA + totalpriceofB + totalpriceofC + totalpriceofD);
        }
    }
}
