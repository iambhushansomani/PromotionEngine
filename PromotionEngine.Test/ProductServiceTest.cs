using System;
using System.Collections.Generic;
using System.Text;
using NUnit;
using NUnit.Framework;
using PromotionEngine.Implementations;
using PromotionEngine.Interfaces;

namespace PromotionEngine.Test
{
    [TestFixture]
    public class ProductServiceTest
    {

        private ProductService ProductService;
        private List<Product> products;
            

        [SetUp]
        public void SetUp()
        {
            ProductService = new ProductService();
            products = new List<Product>();

        }

        [TestCase("A", 50)]
        [TestCase("B", 30)]
        [TestCase("C", 20)]
        [TestCase("D", 15)]
        public void Test_GetPriceByType(string id,int expectedresult)
        {
            var result = ProductService.GetPriceByType(id);

            Assert.AreEqual(result, expectedresult);
        }

        [Test]
        public void Test_GetTotalPrice_NoPromo()
        {

           
            List<string> productlist = new List<string>() { "A", "B", "C" };
            foreach (var item in productlist)
            {
                Product p = new Product();
                p.id = item;
                products.Add(p);
            }
            int result = ProductService.GetTotalPrice(products);
            Assert.AreEqual(100, result);
            
        }

        [Test]
        public void Test_GetTotalPrice_Promo1()
        {
            List<string> productlist = new List<string>() { "A", "A", "A", "A", "A","B", "B", "B", "B", "B","C" };
            foreach (var item in productlist)
            {
                Product p = new Product();
                p.id = item;
                products.Add(p);
            }
            int result = ProductService.GetTotalPrice(products);
            Assert.AreEqual(370, result);

        }

        [Test]
        public void Test_GetTotalPrice_Promo2()
        {
            List<string> productlist = new List<string>() {  "A", "A", "A", "B", "B", "B", "B", "B", "C","D" };
            foreach (var item in productlist)
            {
                Product p = new Product();
                p.id = item;
                products.Add(p);
            }
            int result = ProductService.GetTotalPrice(products);
            Assert.AreEqual(280, result);

        }

    }
}
