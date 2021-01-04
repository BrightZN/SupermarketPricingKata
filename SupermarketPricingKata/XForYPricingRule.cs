namespace SupermarketPricingKata
{
    public class XForYPricingRule : IPricingRule
    {
        protected readonly int thresholdQuantity;
        protected readonly int specialQuantity;

        public XForYPricingRule(int thresholdQuantity, int specialQuantity)
        {
            this.thresholdQuantity = thresholdQuantity;
            this.specialQuantity = specialQuantity;
        }

        public decimal CalculatePrice(Item item, int quantity)
        {
            int occurrencesOfSpecial = quantity / thresholdQuantity;
            int excludedItemsCount = quantity % thresholdQuantity;

            int newItemCount = occurrencesOfSpecial * specialQuantity + excludedItemsCount;

            return item.UnitPrice * newItemCount;
        }
    }
}