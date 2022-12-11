namespace Hexacleanws.Source.Parts.Catalogue.Domain.Model
{
    public class PartsCategoryCode
    {
        public String Value { get; }

        public PartsCategoryCode(string value)
        {
            Value = value;
        }

        public override bool Equals(object? obj)
        {
            return obj is PartsCategoryCode code &&
                   Value == code.Value;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Value);
        }
    }
}
