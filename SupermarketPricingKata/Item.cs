using System;

namespace SupermarketPricingKata
{
    public class Item
    {
        public Item(Sku sku, decimal unitPrice, IPricingRule pricingRule)
        {
            Sku = sku;
            UnitPrice = unitPrice;
            PricingRule = pricingRule;
        }

        public Sku Sku { get; }
        public decimal UnitPrice { get; }
        public IPricingRule PricingRule { get; }

        public decimal CalculatePrice(int quantity)
        {
            return PricingRule.CalculatePrice(this, quantity);
        }
    }
}