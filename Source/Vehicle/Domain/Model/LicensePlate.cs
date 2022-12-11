using System.Text.RegularExpressions;

namespace Hexacleanws.Source.Vehicle.Domain.Model
{
    public class LicensePlate
    {
        public string Value { get; }

        public LicensePlate(string value)
        {
            Value = value;
            Validate();
        }

        private void Validate()
        {
            string vinPattern = @"[A-ZÖÜÄ]{1,3}-[A-ZÖÜÄ]{1,2} [1-9]{1}[0-9]{1,3}";
            Regex vinRegex = new Regex(vinPattern);
            if (!vinRegex.IsMatch(Value))
            {
                throw new Exception("LicensePlate is not valid!");
            }
        }

        public override bool Equals(object? obj)
        {
            return obj is LicensePlate plate &&
                   Value == plate.Value;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Value);
        }
    }
}