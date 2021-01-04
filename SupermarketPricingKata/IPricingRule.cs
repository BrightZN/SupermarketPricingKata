namespace SupermarketPricingKata
{
    public interface IPricingRule
    {
        decimal CalculatePrice(Item item, int quantity);
    }
}