using System;

namespace SupermarketPricingKata
{
    public class ItemGrouping
    {
        public ItemGrouping(Item item, int quantity)
        {
            Item = item;
            Quantity = quantity;
        }

        public Item Item { get; }
        public int Quantity { get; }

        public decimal CalculatePrice() => Item.CalculatePrice(Quantity);
    }
}