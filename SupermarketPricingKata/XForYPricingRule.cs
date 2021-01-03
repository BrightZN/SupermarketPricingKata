namespace SupermarketPricingKata
{
    public class XForYPricingRule : IPricingRule
    {
        public XForYPricingRule(Item item, int itemCount, int specialItemCount)
        {
            Item = item;
            ItemCount = itemCount;
            SpecialItemCount = specialItemCount;
        }

        public int ItemCount { get; }
        public Item Item { get; }
        public int SpecialItemCount { get; }

        public decimal CalculatePricing(ItemGrouping itemGrouping)
        {
            int occurrencesOfSpecial = itemGrouping.Count / ItemCount;
            int excludedItemsCount = itemGrouping.Count % ItemCount;

            int newItemCount = occurrencesOfSpecial * SpecialItemCount + excludedItemsCount;

            return itemGrouping.Item.UnitPrice * newItemCount; // SpecialItemCount
        }
    }
}