namespace SupermarketPricingKata
{
    public class DefaultPricingRule : IPricingRule
    {
        public virtual decimal CalculatePrice(Item item, int quantity)
        {
            return item.UnitPrice * quantity;
        }
    }
}