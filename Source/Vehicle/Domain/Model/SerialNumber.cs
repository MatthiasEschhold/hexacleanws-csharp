using System.Text.RegularExpressions;

namespace clean_architecture_mapping_demo.Source.Vehicle.Domain.Model
{
    public class SerialNumber
    {
        public string Value { get; }
        public SerialNumber(string value)
        {
            Value = value;
            Validate();
        }

        private void Validate()
        {
            Regex serialNumberRegex = new Regex(@"[0-9]{10}");
            if (!serialNumberRegex.IsMatch(Value))
            {
                throw new Exception("Serial number is not valid");
            }
        }

        public override bool Equals(object? obj)
        {
            return obj is SerialNumber number &&
                   Value == number.Value;
        }
    }
}

