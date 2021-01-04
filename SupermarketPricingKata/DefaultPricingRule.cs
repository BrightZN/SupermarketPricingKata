namespace SupermarketPricingKata
{
    public class DefaultPricingRule : IPricingRule
    {
        public decimal CalculatePrice(Item item, int quantity)
        {
            return item.UnitPrice * quantity;
        }
    }
}