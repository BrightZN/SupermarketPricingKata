using System;
using System.Collections.Generic;
using Xunit;

namespace SupermarketPricingKata.Tests
{
    public class SupermarketPricingTests
    {
        [Fact]
        public void Pricing_NoItemsScanned_Calculates0()
        {
            decimal expected = 0.00M;

            var checkout = new Checkout();

            decimal actual = checkout.CalculateTotal();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Pricing_SimpleItemPricing_CalculatesPrice()
        {
            decimal expected = 10.00M;

            var sku = new Sku("Item 1");

            var item = new Item(sku, 5.00M, new DefaultPricingRule());

            var checkout = new Checkout(item);

            checkout.Scan(sku);
            checkout.Scan(sku);

            decimal actual = checkout.CalculateTotal();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Pricing_ThreeForTwo_CalculatesCorrectPrice()
        {
            decimal expected = 20.00M;

            var sku = new Sku("3 for 2 Item");

            var threeForTwoPricingRule = new XForYPricingRule(3, 2);

            var threeForTwoItem = new Item(sku, 10.00M, threeForTwoPricingRule);

            var checkout = new Checkout(threeForTwoItem);

            checkout.Scan(sku);
            checkout.Scan(sku);
            checkout.Scan(sku);

            decimal actual = checkout.CalculateTotal();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Pricing_TwoForOne_CalculatesCorrectPrice()
        {
            decimal expected = 10.00M;

            var sku = new Sku("2 for 1 Item");

            var twoForOnePricingRule = new XForYPricingRule(2, 1);
            var twoForOneItem = new Item(sku, 10.00M, twoForOnePricingRule);

            var checkout = new Checkout(twoForOneItem);

            checkout.Scan(sku);
            checkout.Scan(sku);

            decimal actual = checkout.CalculateTotal();

            Assert.Equal(expected, actual);
        }
    }
}
