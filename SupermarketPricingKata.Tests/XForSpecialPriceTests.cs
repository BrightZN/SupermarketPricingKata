using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SupermarketPricingKata.Tests
{
    public class XForSpecialPriceTests
    {
        [Fact]
        public void CalculatePrice_ThreeForTenCurrencyOnThreeItems_CalculatesCorrectPrice()
        {
            decimal expected = 10.00M;

            var sku = new Sku("3 for R10 Item");

            var threeForTenPricingRule = new XForSpecialPrice(3, 10.00M);

            var threeForTenItem = new Item(sku, 4.50M, threeForTenPricingRule);

            decimal actual = threeForTenItem.CalculatePrice(3);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CalculatePrice_ThreeForTenCurrencyOnSixItems_CalculatesCorrectPrice()
        {
            decimal expected = 20.00M;

            var sku = new Sku("3 for R10 Item");

            var threeForTenPricingRule = new XForSpecialPrice(3, 10.00M);

            var threeForTenItem = new Item(sku, 4.50M, threeForTenPricingRule);

            decimal actual = threeForTenItem.CalculatePrice(6);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CalculatePrice_ThreeForTenCurrencyOnEightItems_CalculatesCorrectPrice()
        {
            decimal expected = 29.00M;

            var sku = new Sku("3 for R10 Item");

            var threeForTenPricingRule = new XForSpecialPrice(3, 10.00M);

            var threeForTenItem = new Item(sku, 4.50M, threeForTenPricingRule);

            decimal actual = threeForTenItem.CalculatePrice(8);

            Assert.Equal(expected, actual);
        }
    }
}
