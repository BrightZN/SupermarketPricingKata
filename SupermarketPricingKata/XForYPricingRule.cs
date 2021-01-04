namespace SupermarketPricingKata
{
    public class XForYPricingRule : IPricingRule
    {
        public XForYPricingRule(int thresholdQuantity, int specialQuantity)
        {
            ThresholdQuantity = thresholdQuantity;
            SpecialQuantity = specialQuantity;
        }

        public int ThresholdQuantity { get; }
        public int SpecialQuantity { get; }

        public decimal CalculatePrice(Item item, int quantity)
        {
            int occurrencesOfSpecial = quantity / ThresholdQuantity;
            int excludedItemsCount = quantity % ThresholdQuantity;

            int newItemCount = occurrencesOfSpecial * SpecialQuantity + excludedItemsCount;

            return item.UnitPrice * newItemCount;
        }
    }
}