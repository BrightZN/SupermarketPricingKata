namespace SupermarketPricingKata
{
    public interface IPricingRule
    {
        decimal CalculatePricing(ItemGrouping itemGrouping);
    }
}