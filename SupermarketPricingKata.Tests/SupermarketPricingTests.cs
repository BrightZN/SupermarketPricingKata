using System;
using System.Collections.Generic;
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

            var checkout = new Checkout();

            checkout.Scan(item);
            checkout.Scan(item);

            decimal actual = checkout.CalculateTotal();

            Assert.Equal(expected, actual);
        }

        //[Fact]
        //public void Pricing_ThreeForTwo_CalculatesCorrectPrice()
        //{
        //    decimal expected = 20.00M;

        //    var threeForTwoItem = new Item("3 for 2 Item", 10.00M);

        //    IPricingRule threeForTwoPricingRule = new XForYPricingRule(threeForTwoItem, 3, 2);

        //    //var checkout = new Checkout(threeForTwoPricingRule);

        //    var itemGrouping = new ItemGrouping(threeForTwoItem, 3);

        //    //checkout.Scan(threeForTwoItem);
        //    //checkout.Scan(threeForTwoItem);
        //    //checkout.Scan(threeForTwoItem);

        //    decimal actual = threeForTwoPricingRule.CalculatePricing(itemGrouping);

        //    //decimal actual = checkout.Total;

        //    Assert.Equal(expected, actual);
        //}

        //[Fact]
        //public void Pricing_TwoForOne_CalculatesCorrectPrice()
        //{
        //    decimal expected = 10.00M;

        //    var twoForOneItem = new Item("2 for 1 Item", 10.00M);

        //    IPricingRule twoForOnePricingRule = new XForYPricingRule(twoForOneItem, 2, 1);

        //    //var checkout = new Checkout(threeForTwoPricingRule);

        //    var itemGrouping = new ItemGrouping(twoForOneItem, 3);

        //    //checkout.Scan(threeForTwoItem);
        //    //checkout.Scan(threeForTwoItem);

        //    decimal actual = twoForOnePricingRule.CalculatePricing(itemGrouping);

        //    //decimal actual = checkout.Total;

        //    Assert.Equal(expected, actual);
        //}
    }
}
