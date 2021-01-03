namespace SupermarketPricingKata
{
    public class XForYPricingRule : IPricingRule
    {
        public XForYPricingRule(Item threeForTwoItem, int v1, int v2)
        {
            this.Item = threeForTwoItem;
            this.ItemCount = v1;
            this.SpecialItemCount = v2;
        }

        public int ItemCount { get; }
        public Item Item { get; }
        public int SpecialItemCount { get; }

        public decimal CalculatePricing(ItemGrouping itemGrouping)
        {
            return itemGrouping.Item.UnitPrice * SpecialItemCount;
        }
    }
}