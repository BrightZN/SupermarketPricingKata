using System;

namespace SupermarketPricingKata
{
    public class Pricer
    {
        public Pricer()
        {
        }

        public decimal CalculatePrice(Item item, int quantity)
        {
            return item.UnitPrice * quantity;
        }
    }
}