using System;
using System.Collections.Generic;
using System.Linq;

namespace SupermarketPricingKata
{
    public class Checkout
    {
        private readonly IEnumerable<Item> _items = new List<Item>();

        private readonly List<Sku> _skus = new List<Sku>();

        public Checkout(params Item[] items)
        {
            _items = items;
        }

        public decimal CalculateTotal()
        {
            return _skus.GroupBy(sku => sku)
                .Select(g => CreateItemGrouping(g.Key, g.Count()))
                .Sum(g => g.CalculatePrice());
        }

        private ItemGrouping CreateItemGrouping(Sku sku, int quantity)
        {
            var item = GetItemBySku(sku);

            return new ItemGrouping(item, quantity);
        }

        private Item GetItemBySku(Sku sku) => _items.Single(i => i.Sku == sku);

        public void Scan(Sku sku) => _skus.Add(sku);
    }
}