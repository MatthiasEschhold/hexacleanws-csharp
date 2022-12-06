using System.Text.RegularExpressions;

namespace clean_architecture_mapping_demo.Source.Vehicle.Domain.Model
{
    public class Vin
    {
        public string Value { get; }

        public Vin(string value)
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
