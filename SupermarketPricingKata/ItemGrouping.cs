namespace SupermarketPricingKata
{
    public class ItemGrouping
    {

        public ItemGrouping(Item item, int count)
        {
            Item = item;
            Count = count;
        }

        public Item Item { get; }
        public int Count { get; }
    }
}