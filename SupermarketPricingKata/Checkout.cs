using System;
using System.Collections.Generic;
using System.Linq;

namespace SupermarketPricingKata
{
    public class Checkout
    {
        private readonly List<Item> _items = new List<Item>();
        private readonly IEnumerable<IPricingRule> _pricingRules;

        public Checkout()
        {
            _pricingRules = Enumerable.Empty<IPricingRule>();
        }

        public Checkout(params IPricingRule[] pricingRules)
        {
            _pricingRules = pricingRules;
        }

        public decimal CalculateTotal()
        {
            return _items.Sum(item => item.UnitPrice);
        }

        public void Scan(Item item)
        {
            _items.Add(item);
        }
    }
}