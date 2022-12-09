using System.Text.RegularExpressions;

namespace Hexacleanws.Source.Vehicle.Domain.Model
{
    public class Vin
    {
        public string Value { get; }

        public Vin(string value)
        {
            Value = value ?? throw new Exception(nameof(value));
            Validate();
        }

        private void Validate()
        {
            string vinPattern = @"(?=.*\d|=.*[A-Z])(?=.*[A-Z])[A-Z0-9]{17}";
            Regex vinRegex = new Regex(vinPattern);
            if (!vinRegex.IsMatch(Value))
            {
                throw new Exception("Vin is not valid!");
            }
        }

        public override bool Equals(object? obj)
        {
            return obj is Vin vin &&
                   Value == vin.Value;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Value);
        }
    }
}
