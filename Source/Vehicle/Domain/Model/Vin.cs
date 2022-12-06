using System.Text.RegularExpressions;

namespace Hexacleanws.Vehicle.Domain.Model
{
    public class Vin
    {
        public String Value { get; }

        public Vin(String value)
        {
            Value = value;
            Validate();
        }

        private void Validate()
        {
            Regex vinRegex = new Regex(@"(?=.*\d|=.*[A-Z])(?=.*[A-Z])[A-Z0-9]{17}");
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
    }
}
