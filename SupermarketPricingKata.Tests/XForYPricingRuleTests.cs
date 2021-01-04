using Xunit;

namespace SupermarketPricingKata.Tests
{
    public class XForYPricingRuleTests
    {
        [Fact]
        public void CalculatePrice_ThreeForTwo_CalculatesCorrectPrice()
        {
            decimal expected = 20.00M;

            var sku = new Sku("3 for 2 Item");

            var threeForTwoPricingRule = new XForYPricingRule(3, 2);

            var threeForTwoItem = new Item(sku, 10.00M, threeForTwoPricingRule);

            decimal actual = threeForTwoItem.CalculatePrice(3);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CalculatePrice_TwoForOne_CalculatesCorrectPrice()
        {
            decimal expected = 10.00M;

            var sku = new Sku("2 for 1 Item");

            IPricingRule twoForOnePricingRule = new XForYPricingRule(2, 1);

            var twoForOneItem = new Item(sku, 10.00M, twoForOnePricingRule);

            decimal actual = twoForOneItem.CalculatePrice(2);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CalculatePrice_TwoForOneOnFourItems_CalculatesCorrectPrice()
        {
            decimal expected = 20.00M;

            var sku = new Sku("2 for 1 Item");

            IPricingRule twoForOnePricingRule = new XForYPricingRule(2, 1);

            var twoForOneItem = new Item(sku, 10.00M, twoForOnePricingRule);

            decimal actual = twoForOneItem.CalculatePrice(4);

            Assert.Equal(expected, actual);
        }
    }
}
