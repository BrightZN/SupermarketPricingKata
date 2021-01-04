namespace SupermarketPricingKata
{
    public class XForSpecialPrice : DefaultPricingRule
    {
        protected readonly int thresholdQuantity;
        protected readonly decimal specialPrice;

        public XForSpecialPrice(int thresholdQuantity, decimal specialPrice)
        {
            this.thresholdQuantity = thresholdQuantity;
            this.specialPrice = specialPrice;
        }

        public override decimal CalculatePrice(Item item, int quantity)
        {
            int occurrencesOfSpecial = quantity / thresholdQuantity;
            int excludedItemsCount = quantity % thresholdQuantity;

            return occurrencesOfSpecial * specialPrice + base.CalculatePrice(item, excludedItemsCount);
        }
    }
}