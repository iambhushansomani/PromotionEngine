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

        [SetUp]
        public void SetUp()
        {
            ProductService = new ProductService();
        }

        [TestCase("A", 50)]
        [TestCase("B", 30)]
        [TestCase("C", 20)]
        [TestCase("D", 15)]
        public void IsPrime_InputIs1_ReturnFalse(string id,int expectedresult)
        {
            var result = ProductService.GetPriceByType(id);

            Assert.AreEqual(result, expectedresult);
        }

    }
}
