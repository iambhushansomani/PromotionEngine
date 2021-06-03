using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.Interfaces
{
    public interface IProductInterface
    {
        int GetPriceByType(string productid);
        int GetTotalPrice(List<Product> products);
    }
}
