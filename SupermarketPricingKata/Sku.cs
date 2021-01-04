using System;

namespace SupermarketPricingKata
{
    public class Sku : IEquatable<Sku>
    {
        public Sku(string value)
        {
            this.Value = value;
        }

        public string Value { get; }

        public override bool Equals(object obj)
        {
            return Equals(obj as Sku);
        }

        public bool Equals(Sku other)
        {
            return other != null &&
                   Value == other.Value;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Value);
        }
    }
}