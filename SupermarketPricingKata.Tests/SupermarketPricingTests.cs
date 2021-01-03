using System;
using Xunit;

namespace SupermarketPricingKata.Tests
{
    public class SupermarketPricingTests
    {
        [Fact]
        public void Pricing_SimpleItemPricing_CalculatesPrice()
        {
            decimal expected = 10.00M;

            var item = new Item("Item 1", 5.00M);

            var pricer = new Pricer();

            decimal actual = pricer.CalculatePrice(item, 2);

            Assert.Equal(expected, actual);
        }

        public void Pricing_ThreeForTwo_CalculatesPriceForSingleItem()
        {
            decimal expected = 20.00M;

            decimal unitPrice = 10.00M;
            int quantity = 3;
            int specialQuantity = 2;

            decimal actual = unitPrice * specialQuantity;

            Assert.Equal(expected, actual);
        }
    }
}
