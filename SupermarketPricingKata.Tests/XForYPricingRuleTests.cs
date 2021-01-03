using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SupermarketPricingKata.Tests
{
    public class XForYPricingRuleTests
    {
        [Fact]
        public void CalculatePricing_ThreeForTwo_CalculatesCorrectPrice()
        {
            decimal expected = 20.00M;

            var threeForTwoItem = new Item("3 for 2 Item", 10.00M);

            var threeForTwoPricingRule = new XForYPricingRule(threeForTwoItem, 3, 2);

            var itemGrouping = new ItemGrouping(threeForTwoItem, 3);

            decimal actual = threeForTwoPricingRule.CalculatePricing(itemGrouping);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CalculatePricing_TwoForOne_CalculatesCorrectPrice()
        {
            decimal expected = 10.00M;

            var twoForOneItem = new Item("2 for 1 Item", 10.00M);

            IPricingRule twoForOnePricingRule = new XForYPricingRule(twoForOneItem, 2, 1);

            var itemGrouping = new ItemGrouping(twoForOneItem, 2);

            decimal actual = twoForOnePricingRule.CalculatePricing(itemGrouping);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CalculatePricing_TwoForOneOnFourItems_CalculatesCorrectPrice()
        {
            decimal expected = 20.00M;

            var twoForOneItem = new Item("2 for 1 Item", 10.00M);

            IPricingRule twoForOnePricingRule = new XForYPricingRule(twoForOneItem, 2, 1);

            var itemGrouping = new ItemGrouping(twoForOneItem, 4);

            decimal actual = twoForOnePricingRule.CalculatePricing(itemGrouping);

            Assert.Equal(expected, actual);
        }
    }
}
