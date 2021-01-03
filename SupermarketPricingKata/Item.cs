namespace SupermarketPricingKata
{
    public class Item
    {
        public Item(string name, decimal unitPrice)
        {
            Name = name;
            UnitPrice = unitPrice;
        }

        public string Name { get; }
        public decimal UnitPrice { get; }
    }
}