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

            decimal unitPrice = 5.00M;
            int quantity = 2;

            decimal actual = unitPrice * quantity;

            Assert.Equal(expected, actual);
        }


    }
}
